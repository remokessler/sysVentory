namespace Datasource {
    public class ItemProperty {
        public ItemProperty(string name, object value) {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public object Value { get; }
    }
}
