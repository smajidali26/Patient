using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class AddressRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        return Regex.Replace(input, @"\d+\s+[A-Za-z\s]+,\s*[A-Za-z\s]+,\s*[A-Za-z]{2,3}", "[REDACTED]");
    }
}
