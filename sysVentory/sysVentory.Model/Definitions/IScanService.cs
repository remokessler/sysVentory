namespace sysVentory.Model.Definitions
{
    // Abstraction of ScanService
    public interface IScanService
    {
        IScan NewScan(string macAddress);
        bool DeleteScan(string macAddress, int scanId);
    }
}