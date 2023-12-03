using PCViewer.Services;

namespace PCViewer.Helpers;
public class ComputerDirector
{
    public static void BuildComputer(MyComputerBuilder builder) 
    {
        builder.BuildMotherboard();
        builder.BuildProcessor();
        builder.BuildRam();
        builder.BuildStorageDevice();
        builder.BuildPowerSupply();
        builder.BuildGraphicCard();
        builder.BuildCooler();
    }
}
