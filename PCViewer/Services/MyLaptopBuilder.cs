using PCViewer.Contracts.Services;
using PCViewer.Core.Contracts;
using PCViewer.Core.Models;
using PCViewer.Core.Services;

namespace PCViewer.Services;
public class MyLaptopBuilder : LaptopBuilder
{
    private readonly Laptop _laptop;
    private readonly ILogger _logger;

    public MyLaptopBuilder(ILogger logger)
    {
        _laptop = new Laptop();
        _logger = logger;
    }

    public override void SetUpLaptop()
    {
        _laptop.Cost = 42999;
        _laptop.Color = "Белый";
        _laptop.Weight = 1.25f;
        _laptop.Model = "Swift 3 (SF314-44)";
        _laptop.Brand = "Acer";
        _laptop.Description = "Acer Swift 3 разработан с прицелом на массового потребителя: он доступный и мобильный, хорошо собран, радует хорошей производительностью и удобной клавиатурой, а также имеет качественный дисплей. Более того - в этой модели есть также порт Thunderbolt 4.";
        _logger.Log("Ноутбук настроен");
    }

    public override void BuildProcessor()
    {
        var processor = new Processor
        {
            Frequency = 2.6f,
            MaxFrequency = 3.8f,
            CoreNumber = 4,
            ThreadNumber = 8,
            Model = "Ryzen 3 5300U",
            Brand = "AMD",
            GraphicCard = new GraphicCard
            {
                Model = "Radeon RX Vega 6",
                Brand = "AMD"
            }
        };

        var processorComplect = new ComponentComplect<Processor>(processor);

        _logger.Log("Собран комплект процессора");

        _laptop.Parts.Add(processorComplect);
    }
    public override void BuildRam()
    {
        var ram = new RAM
        {
            Capacity = 8192,
            FormFactor = "SO-DIMM",
            Speed = 4266,
            Type = "LPDDR4X"
        };

        var ramComplect = new ComponentComplect<RAM>(ram);

        _logger.Log("Собран комплект ОЗУ");

        _laptop.Parts.Add(ramComplect);
    }
    public override void BuildStorageDevice()
    {
        var ssd1 = new SSD
        {
            Capacity = 512,
            Type = "NVMe",
        };

        var ssd2 = new HDD
        {
            Brand = "Toshiba",
            Model = "DT01",
            Capacity = 1024,
            LifeResource = 300,
            Speed = 550,
            Cost = 5299,
            SpinSpeed = 7200
        };

        var ssdComplect = new ComponentComplect<StorageDevice>(ssd1, ssd2);

        _logger.Log("Собран комплект SSD");

        _laptop.Parts.Add(ssdComplect);
    }
    public override void BuildGraphicCard() { }
    public override void BuildBattery()
    {
        var battery = new Battery
        {
             Capacity = 48
        };

        var batteryComplect = new ComponentComplect<Battery>(battery);

        _logger.Log("Собран комплект батареи");

        _laptop.Parts.Add(batteryComplect);
    }
    public override Laptop GetResult()
    {
        _logger.Log($"Возвращение экземпляра ноутбука из {typeof(MyLaptopBuilder).Name}");
        return _laptop;
    }
}
