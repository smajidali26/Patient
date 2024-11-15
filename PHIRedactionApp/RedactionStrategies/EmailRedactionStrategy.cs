using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class EmailRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        return Regex.Replace(input, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}", "[REDACTED]");
    }
}
