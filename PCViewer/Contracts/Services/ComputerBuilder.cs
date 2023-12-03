using PCViewer.Core.Models;

namespace PCViewer.Contracts.Services;
public abstract class ComputerBuilder
{
    public abstract void BuildMotherboard();
    public abstract void BuildProcessor();
    public abstract void BuildRam();
    public abstract void BuildStorageDevice();
    public abstract void BuildPowerSupply();
    public abstract void BuildGraphicCard();
    public abstract void BuildCooler();
    public abstract Computer GetResult();
}
