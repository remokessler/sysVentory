﻿using System.Collections.Generic;
using sysVentory.Model.Definitions;

namespace sysVentory.Model.ScanServiceHelpers
{
    internal class Item : IScanInformationGroup {
        public Item(string itemType, List<ItemProperty> properties) {
            Type = itemType;
            Properties = properties;
        }

        public string Type { get; set; }
        public IEnumerable<IScanInformation> Properties { get; set; }
    }
}