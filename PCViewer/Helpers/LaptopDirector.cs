using PCViewer.Contracts.Services;

namespace PCViewer.Helpers;
public class LaptopDirector
{
    public static void BuildLaptop(LaptopBuilder builder)
    {
        builder.SetUpLaptop();
        builder.BuildProcessor();
        builder.BuildRam();
        builder.BuildStorageDevice();
        builder.BuildGraphicCard();
        builder.BuildBattery();
    }
}
