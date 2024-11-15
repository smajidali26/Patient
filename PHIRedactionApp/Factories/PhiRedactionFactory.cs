using PHIRedactionApp.Interfaces;
using PHIRedactionApp.RedactionStrategies;

namespace PHIRedactionApp.Factories;

public static class PhiRedactionFactory
{
    public static IPhiRedactionStrategy GetStrategy(string phiType)
    {
        return phiType switch
        {
            "Name" => new NameRedactionStrategy(),
            "SSN" => new SsnRedactionStrategy(),
            "PhoneNumber" => new PhoneNumberRedactionStrategy(),
            "Email" => new EmailRedactionStrategy(),
            "Address" => new AddressRedactionStrategy(),
            "DOB" => new DateOfBirthRedactionStrategy(),
            "MRN" => new MedicalRecordRedactionStrategy(),
            _ => throw new ArgumentException("Invalid PHI type")
        };
    }
}
