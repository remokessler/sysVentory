namespace sysVentory.Model.Definitions.Types
{
    internal class ScanInformation : IScanInformation
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
