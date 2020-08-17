using System;
using sysVentory.Events;
using sysVentory.Model.Definitions;

namespace sysVentory.Helper
{
    public class EventHelper
    {
        public event EventHandler<SelectedComputerChangedEventArgs> OnSelectedComputerChanged;
        public event EventHandler<NewScanEventArgs> OnNewScan;
        public static EventHelper Instance => _instance = _instance ?? new EventHelper();
        private static EventHelper _instance { get; set; }

        private EventHelper()
        {

        }

        public void EmitSelectedComputerChanged(IComputer sender, SelectedComputerChangedEventArgs sccea)
        {
            OnSelectedComputerChanged(sender, sccea);
        }

        public void EmitNewScan(object sender, NewScanEventArgs nsea)
        {
            OnNewScan(sender, nsea);
        }
    }
}
