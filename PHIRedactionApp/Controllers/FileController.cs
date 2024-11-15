using Microsoft.AspNetCore.Mvc;
using PHIRedactionApp.Processors;
using PHIRedactionApp.Services;

namespace PHIRedactionApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileController : ControllerBase
{

    private readonly FileUploadService _fileUploadService;

    public FileController(FileUploadService fileUploadService)
    {
        _fileUploadService = fileUploadService;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        if (file == null || file.Length == 0) return BadRequest("Upload a valid file.");

        var phiTypes = new List<string> { "Name", "SSN", "PhoneNumber", "Email", "DOB", "MRN", "Address" };
        var processor = new RedactionProcessor(phiTypes);

        Directory.CreateDirectory("output");
        var outputFilePath = Path.Combine("output", Path.GetFileNameWithoutExtension(file.FileName) + "_sanitized.txt");
        
        using (StreamWriter writer = new StreamWriter(outputFilePath, append: false)) {
            await _fileUploadService.ProcessFileLineByLineAsync(file, async line => {
                var redactedContent = processor.Process(line);
                await writer.WriteLineAsync(redactedContent);
            });
        }

        return Ok(new { Message = "File processed successfully", Path = outputFilePath });
    }
}
