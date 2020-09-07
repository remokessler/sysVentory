using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    /** Event arguments for when a new scan is added */
    public class NewScanEventArgs : EventArgs
    {
        public IScan NewScan { get; set; }
        public NewScanEventArgs(IScan scan)
        {
            NewScan = scan;
        }
    }
}
