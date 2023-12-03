using PCViewer.Contracts.Services;
using PCViewer.Core.Models;

namespace PCViewer.Services;
public class MyComputerBuilder : ComputerBuilder
{
    private readonly Computer _computer;

    public MyComputerBuilder() 
    {
        _computer = new Computer();
    }

    public override void BuildMotherboard()
    {
        var motherboard = new Motherboard
        {
            MemoryType = "DDR5",
            SocketType = "LGA 1700",
            Chipset = "B660M",
            Brand = "MSI",
            Cost = 16999
        };

        var motherboardPart = new ComponentComplect<Motherboard>(motherboard);

        _computer.Parts.Add(motherboardPart);
    }
    public override void BuildProcessor()
    {
        var processor = new Processor
        {
            Frequency = 2.5f,
            MaxFrequency = 4.4f,
            CoreNumber = 6,
            ThreadNumber = 12,
            Model = "Core i5-12400",
            Brand = "Intel",
            Cost = 13799,
            GraphicCard = new GraphicCard
            {
                Model = "UHD Graphics 730",
                Brand = "Intel"
            }
        };

        var processorPart = new ComponentComplect<Processor>(processor);

        _computer.Parts.Add(processorPart);
    }
    public override void BuildRam()
    {
        var ram1 = new RAM
        {
            Capacity = 8192,
            Type = "DDR5",
            Speed = 5600,
            Model = "FURY Beast Black",
            Brand = "Kingston"
        };

        var ram2 = new RAM
        {
            Capacity = 8192,
            Type = "DDR5",
            Speed = 5600,
            Model = "FURY Beast Black",
            Brand = "Kingston"
        };

        var ramComplect = new ComponentComplect<RAM>(9699, ram1, ram2);

        _computer.Parts.Add(ramComplect);
    }
    public override void BuildStorageDevice()
    {
        var ssd = new SSD
        {
            LifeResource = 600,
            Capacity = 1024,
            Speed = 3500,
            Type = "M.2",
            Model = "970 EVO Plus",
            Brand = "Samsung",
            Cost = 11799
        };

        var ssdComplect = new ComponentComplect<SSD>(ssd);

        _computer.Parts.Add(ssdComplect);
    }
    public override void BuildPowerSupply()
    {
        var powerSupply = new PowerSupply
        {
            Wattage = 850,
            FormFactor = "ATX",
            Model = "MPG A850GF",
            Brand = "MSI",
            Cost = 10799
        };

        var powerSupplyComplect = new ComponentComplect<PowerSupply>(powerSupply);

        _computer.Parts.Add(powerSupplyComplect);
    }
    public override void BuildGraphicCard()
    {
        var graphicCard = new GraphicCard
        {
            FormFactor = "Micro-ATX",
            MemorySize = 10240,
            Model = "RTX 3080",
            Brand = "MSI",
            Cost = 50000
        };

        var graphicCardComplect = new ComponentComplect<GraphicCard>(graphicCard);

        _computer.Parts.Add(graphicCardComplect);
    }
    public override void BuildCooler()
    {
        var cooler = new Cooler
        {
            DissipationPower = 250,
            Model = "MAG CORELIQUID",
            Brand = "MSI",
            Cost = 8599
        };

        var coolerComplect = new ComponentComplect<Cooler>(cooler);

        _computer.Parts.Add(coolerComplect);
    }
    public override Computer GetResult()
    {
        return _computer;
    }
}
