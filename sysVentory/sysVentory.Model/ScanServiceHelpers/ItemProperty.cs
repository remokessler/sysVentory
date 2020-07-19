using sysVentory.Model.Definitions;

namespace sysVentory.Model.ScanServiceHelpers
{
    internal class ItemProperty : IScanInformation {
        public ItemProperty(string name, object value) {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public object Value { get; set; }
    }
}
