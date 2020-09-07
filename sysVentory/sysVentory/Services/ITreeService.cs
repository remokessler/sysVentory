using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory.Services
{
    public interface ITreeService
    {
        void BuildTree(TreeView tv, IScan scan);
    }
}
