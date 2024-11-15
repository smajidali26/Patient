namespace PHIRedactionApp.Services
{
    public class FileUploadService
    {
        public async Task ProcessFileLineByLineAsync(IFormFile file, Func<string, Task> processLine)
        {
            try
            {
                using (var stream = file.OpenReadStream())
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        await processLine(line); // Process each line immediately
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while processing the file: {ex.Message}");
            }
        }

        
    }
}
