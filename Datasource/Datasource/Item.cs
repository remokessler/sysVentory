using System.Collections.Generic;

namespace Datasource {
    public class Item {
        public Item(string itemType, List<ItemProperty> properties) {
            ItemType = itemType;
            Properties = properties;
        }

        public string ItemType { get; }
        public List<ItemProperty> Properties { get; }
    }
}