using System.Text.RegularExpressions;
using PHIRedactionApp.Interfaces;

namespace PHIRedactionApp.RedactionStrategies;

public class MedicalRecordRedactionStrategy : IPhiRedactionStrategy
{
    public string Redact(string input)
    {
        return Regex.Replace(input, @"MRN-\d{7}", "[REDACTED]");
    }
}
