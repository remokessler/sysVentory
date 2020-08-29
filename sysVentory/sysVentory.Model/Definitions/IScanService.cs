namespace sysVentory.Model.Definitions
{
    public interface IScanService
    {
        IScan NewScan(string macAddress);
        bool DeleteScan(string macAddress, int scanId);
    }
}