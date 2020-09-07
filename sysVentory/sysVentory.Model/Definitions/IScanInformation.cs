namespace sysVentory.Model.Definitions
{
    // Abstraction of ScanInfromation
    public interface IScanInformation
    {
        string Name { get; set; }
        object Value { get; set; }
    }
}
