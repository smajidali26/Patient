using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;
public class SsnRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        if (input.ToLower().StartsWith("social security number: "))
            return "Social Security Number: [REDACTED]";
        return input;
    }
}
