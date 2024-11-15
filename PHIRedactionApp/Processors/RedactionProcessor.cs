using PHIRedactionApp.Interfaces;
using PHIRedactionApp.Factories;

namespace PHIRedactionApp.Processors;

public class RedactionProcessor
{
    private readonly List<IPhiRedactionStrategy> _strategies;

    public RedactionProcessor(IEnumerable<string> phiTypes)
    {
        _strategies = new List<IPhiRedactionStrategy>();

        foreach (var type in phiTypes)
        {
            _strategies.Add(PhiRedactionFactory.GetStrategy(type));
        }
    }

    public string Process(string content)
    {
        foreach (var strategy in _strategies)
        {
            content = strategy.Redact(content);
        }
        return content;
    }
}
