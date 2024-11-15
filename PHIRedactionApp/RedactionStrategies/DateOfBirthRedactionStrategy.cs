using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class DateOfBirthRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        if(input.ToLower().StartsWith("date of birth: ")) {
            return "Date of Birth: [REDACTED]";
        }
        return input;
    }
}
