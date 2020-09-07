using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    /** Event arguments when the selected computer is changed */
    public class SelectedComputerChangedEventArgs : EventArgs
    {
        public IComputer NewSelectedComputer { get; set; }

        public SelectedComputerChangedEventArgs(IComputer computer)
        {
            NewSelectedComputer = computer;
        }
    }
}
