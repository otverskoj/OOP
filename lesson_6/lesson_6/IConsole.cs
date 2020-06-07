using System.Collections.Generic;

namespace lesson_6
{
    public interface IConsole
    {
        ProcessorTypes ProcessorType { get; set; }
        ManufacturerNames ManufactName { get; set; }
        MediaTypes MediaType { get; set; }
        string ConsoleName { get; set; }
        int HardDiskCapacity { get; set; }
        List<string> InstalledGames { get; set; }
        List<string> SystemAccounts { get; set; }
    }
}