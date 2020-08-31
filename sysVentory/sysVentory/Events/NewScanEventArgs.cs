using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    public class NewScanEventArgs : EventArgs
    {
        public IScan NewScan { get; set; }
        public NewScanEventArgs(IScan scan)
        {
            NewScan = scan;
        }
    }
}
