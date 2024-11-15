using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class PhoneNumberRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        return Regex.Replace(input, @"\+?(\d{1,3})?[-.\s]?\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}", "[REDACTED]");
    }
}
