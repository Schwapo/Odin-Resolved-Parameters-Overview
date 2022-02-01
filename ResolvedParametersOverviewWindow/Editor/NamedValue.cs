namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class NamedValue
    {
        public string Name;
        public string Type;
        public string Description;

        public NamedValue(string name, string type, string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }
    }
}