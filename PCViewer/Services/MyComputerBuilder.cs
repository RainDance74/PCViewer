using PCViewer.Contracts.Services;
using PCViewer.Core.Contracts;
using PCViewer.Core.Models;
using PCViewer.Core.Services;
using System.Runtime.CompilerServices;

namespace PCViewer.Services;
public class MyComputerBuilder : ComputerBuilder
{
    
    private readonly Computer _computer;
    private readonly ILogger _logger;

    public MyComputerBuilder(ILogger logger)
    {
        _computer = new Computer();
        _logger = logger;
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

        _logger.Log("Собран комплект материнской платы");

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

        _logger.Log("Собран комплект процессора");

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

        _logger.Log("Собран комплект ОЗУ");

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

        var ssdComplect = new ComponentComplect<StorageDevice>(ssd);

        _logger.Log("Собран комплект SSD");

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

        _logger.Log("Собран комплект БП");

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

        _logger.Log("Собран комплект видеокарты");

        _computer.Parts.Add(graphicCardComplect);
    }
    public override void BuildCooler()
    {
        var cooler = new Cooler
        {
            TDP = 250,
            Model = "MAG CORELIQUID",
            Brand = "MSI",
            Cost = 8599
        };

        var coolerComplect = new ComponentComplect<Cooler>(cooler);

        _logger.Log("Собран комплект кулера");

        _computer.Parts.Add(coolerComplect);
    }
    public override Computer GetResult()
    {
        _logger.Log($"Возвращение экземпляра компьютера из {typeof(MyComputerBuilder).Name}");
        return _computer;
    }
}
