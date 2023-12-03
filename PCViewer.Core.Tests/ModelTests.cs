using PCViewer.Core.Models;

namespace PCViewer.Core.Tests;

[TestFixture]
public class ModelTests
{

    [Test]
    public void Cost_Calculating_Should_Return_Right_Value_On_PC()
    {
        // Arrange
        var pc = new Computer();

        #region Создание деталей

        var motherboard = new Motherboard
        {
            Cost = 17000
        };

        var processor = new Processor
        {
            Cost = 13800
        };

        var ram = new RAM();

        var ssd = new SSD
        {
            Cost = 11800
        };

        var powerSupply = new PowerSupply
        {
            Cost = 10800
        };

        var graphicCard = new GraphicCard
        {
            Cost = 50000
        };

        var cooler = new Cooler
        {
            Cost = 8600
        };

        #region Инициализация деталей 

        var motherboardPart = new ComponentComplect<Motherboard>(motherboard);

        var processorPart = new ComponentComplect<Processor>(processor);

        var ramPart = new ComponentComplect<RAM>(9700, ram, ram); // Вставляем 2 одинаковых плашки ОЗУ

        var ssdPart = new ComponentComplect<SSD>(ssd);

        var powerSupplyPart = new ComponentComplect<PowerSupply>(powerSupply);

        var graphicCardPart = new ComponentComplect<GraphicCard>(graphicCard);

        var coolerPart = new ComponentComplect<Cooler>(cooler);

        #endregion

        #endregion

        #region Вставляем детали в компьютер

        pc.Parts.Add(motherboardPart);
        pc.Parts.Add(processorPart);
        pc.Parts.Add(ramPart);
        pc.Parts.Add(ssdPart);
        pc.Parts.Add(powerSupplyPart);
        pc.Parts.Add(graphicCardPart);
        pc.Parts.Add(coolerPart);

        #endregion

        // Act
        var totalCost = pc.Cost;

        // Assert
        Assert.That(totalCost, Is.EqualTo(121700));
    }

    [Test]
    public void Cost_Calculating_Should_Return_Right_Value_On_Laptop()
    {
        // Arrange
        var pc = new Laptop()
        {
            Cost = 39999
        };

        // Act
        var totalCost = pc.Cost;

        // Assert
        Assert.That(totalCost, Is.EqualTo(39999));
    }

    [Test]
    public void Cost_Calculating_Should_Return_Right_Value_On_Laptop_With_Added_Parts()
    {
        // Arrange
        var pc = new Laptop()
        {
            Cost = 40000
        };

        var ssd = new SSD
        {
            Cost = 6000
        };

        var ssdPart = new ComponentComplect<SSD>(ssd);

        pc.Parts.Add(ssdPart);

        // Act
        var totalCost = pc.Cost;

        // Assert
        Assert.That(totalCost, Is.EqualTo(46000));
    }

    [Test]
    public void Motherboard_Brand_Should_Return_Value_FromPC()
    {
        // Arrange
        var pc = new Computer();

        var motherboard = new Motherboard
        {
            Brand = "MSI"
        };

        var motherboardPart = new ComponentComplect<Motherboard>(motherboard);

        pc.Parts.Add(motherboardPart);

        // Act
        var targetPartInPC = pc.Parts.Find(p => p.GetType().GenericTypeArguments[0] == typeof(Motherboard));
        var motherboardPartInPC = targetPartInPC as ComponentComplect<Motherboard>;
        var motherboardInPC = motherboardPartInPC?.Values;
        var motherBoardBrand = motherboardInPC?.Single().Brand;

        // Assert
        Assert.That(motherBoardBrand, Is.EqualTo("MSI"));
    }

    [Test]
    public void Motherboard_Socket_Should_Return_Value_FromPC()
    {
        // Arrange
        var pc = new Computer();

        var motherboard = new Motherboard
        {
            SocketType = "LGA 1700"
        };

        var motherboardPart = new ComponentComplect<Motherboard>(motherboard);

        pc.Parts.Add(motherboardPart);

        // Act
        var targetPartInPC = pc.Parts.Find(p => p.GetType().GenericTypeArguments[0] == typeof(Motherboard));
        var motherboardPartInPC = targetPartInPC as ComponentComplect<Motherboard>;
        var motherboardInPC = motherboardPartInPC?.Values;
        var motherboardSocket = motherboardInPC?.Single().SocketType;

        // Assert
        Assert.That(motherboardSocket, Is.EqualTo("LGA 1700"));
    }

    [Test]
    public void RamCost_Should_Return_Total_Value_FromPC()
    {
        // Arrange
        var pc = new Computer();

        var cheepRam = new RAM
        {
            Cost = 2500
        };

        var expensiveRam = new RAM
        {
            Cost = 10000
        };

        var ramPart = new ComponentComplect<RAM>(cheepRam, expensiveRam);

        pc.Parts.Add(ramPart);

        // Act
        var targetPartInPC = pc.Parts.Find(p => p.GetType().GenericTypeArguments[0] == typeof(RAM));
        var ramPartInPC = targetPartInPC as ComponentComplect<RAM>;
        var ramComplectCost = ramPartInPC?.ComplectCost;

        // Assert
        Assert.That(ramComplectCost, Is.EqualTo(12500));
    }
}