using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    public class SelectedComputerChangedEventArgs : EventArgs
    {
        public IComputer NewSelectedComputer { get; set; }

        public SelectedComputerChangedEventArgs(IComputer computer)
        {
            NewSelectedComputer = computer;
        }
    }
}
