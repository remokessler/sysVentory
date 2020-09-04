using System;
using sysVentory.Model.Definitions;

namespace sysVentory.Events
{
    /*===================================================================*/
    /*SelectedComputerChanged is an initialize of the interface IComputer*/
    /*===================================================================*/
    public class SelectedComputerChangedEventArgs : EventArgs
    {
        public IComputer NewSelectedComputer { get; set; }

        public SelectedComputerChangedEventArgs(IComputer computer)
        {
            NewSelectedComputer = computer;
        }
    }
}
