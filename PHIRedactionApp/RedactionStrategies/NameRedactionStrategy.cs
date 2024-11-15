using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class NameRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        if(input.ToLower().StartsWith("patient name: ")) {
            return "Patient Name: [REDACTED]";
        }
        return input;
    }
}
