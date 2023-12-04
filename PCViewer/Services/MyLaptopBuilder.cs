using PCViewer.Contracts.Services;
using PCViewer.Core.Models;

namespace PCViewer.Services;
public class MyLaptopBuilder : LaptopBuilder
{
    private readonly Laptop _laptop;

    public MyLaptopBuilder()
    {
        _laptop = new Laptop();
    }

    public override void SetUpLaptop()
    {
        _laptop.Cost = 42999;
        _laptop.Color = "Белый";
        _laptop.Weight = 1.25f;
        _laptop.Model = "Swift 3 (SF314-44)";
        _laptop.Brand = "Acer";
        _laptop.Description = "Acer Swift 3 разработан с прицелом на массового потребителя: он доступный и мобильный, хорошо собран, радует хорошей производительностью и удобной клавиатурой, а также имеет качественный дисплей. Более того - в этой модели есть также порт Thunderbolt 4.";
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

        _laptop.Parts.Add(ramComplect);
    }
    public override void BuildStorageDevice()
    {
        var ssd1 = new SSD
        {
            Capacity = 512,
            Type = "NVMe",
        };

        var ssd2 = new SSD
        {
            Brand = "Kingston",
            Model = "KC600",
            Capacity = 512,
            LifeResource = 300,
            Speed = 550,
            Cost = 5899,
            Type = "SATA"
        };

        var ssdComplect = new ComponentComplect<SSD>(ssd1, ssd2);

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

        _laptop.Parts.Add(batteryComplect);
    }
    public override Laptop GetResult()
    {
        return _laptop;
    }
}
