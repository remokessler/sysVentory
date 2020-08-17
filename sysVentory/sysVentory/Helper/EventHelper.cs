using System;
using sysVentory.Events;

namespace sysVentory.Helper
{
    public class EventHelper
    {
        public event EventHandler<SelectedComputerChangedEventArgs> OnSelectedComputerChanged;
        public static EventHelper Instance => _instance = _instance ?? new EventHelper();
        private static EventHelper _instance { get; set; }

        private EventHelper()
        {

        }

        public void EmitSelectedComputerChanged(object sender, SelectedComputerChangedEventArgs sccea)
        {
            OnSelectedComputerChanged(sender, sccea);
        }
    }
}
