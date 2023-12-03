using PCViewer.Core.Models;

namespace PCViewer.Contracts.Services;
public abstract class LaptopBuilder
{
    public abstract void SetUpLaptop();
    public abstract void BuildProcessor();
    public abstract void BuildRam();
    public abstract void BuildStorageDevice();
    public abstract void BuildBattery();
    public abstract void BuildGraphicCard();
    public abstract Laptop GetResult();
}
