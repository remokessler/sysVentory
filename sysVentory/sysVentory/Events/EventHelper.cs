using System;
using sysVentory.Events;
using sysVentory.Model.Definitions;

namespace sysVentory.Helper
{
    /** Singleton class to subscribe and emit events */
    public class EventHelper
    {
        public event EventHandler<SelectedComputerChangedEventArgs> OnSelectedComputerChanged;
        public event EventHandler<NewScanEventArgs> OnNewScan;
        public static EventHelper Instance => _instance = _instance ?? new EventHelper();
        private static EventHelper _instance { get; set; }

        private EventHelper()
        {

        }

        /** Emits an event to notify all members that a computer is changed in the view */
        public void EmitSelectedComputerChanged(object sender, SelectedComputerChangedEventArgs sccea)
        {
            OnSelectedComputerChanged(sender, sccea);
        }

        /** Emits an event to notify all members that a new scan is added */
        public void EmitNewScan(object sender, NewScanEventArgs nsea)
        {
            OnNewScan(sender, nsea);
        }
    }
}
