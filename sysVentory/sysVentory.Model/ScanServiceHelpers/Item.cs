using System.Collections.Generic;
using sysVentory.Model.Definitions;

namespace sysVentory.Model.ScanServiceHelpers
{
    /** Class given for the project modified to be object orientated */
    internal class Item : IScanInformationGroup
    {
        public string Type { get; set; }
        public IEnumerable<IScanInformation> Properties { get; set; }
        public Item(string itemType, List<ItemProperty> properties)
        {
            Type = itemType;
            Properties = properties;
        }
    }
}