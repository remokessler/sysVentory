using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    public class NewScanEventArgs : EventArgs
    {
        /*===========================================================*/
        /*NewScanEventArgs.cs is an initialize of the interface IScan*/
        /*===========================================================*/
        public IScan NewScan { get; set; }
        public NewScanEventArgs(IScan scan)
        {
            NewScan = scan;
        }
    }
}
