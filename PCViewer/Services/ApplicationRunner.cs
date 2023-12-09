using PCViewer.Contracts.Services;
using PCViewer.Core.Contracts;
using PCViewer.Core.Models;
using PCViewer.Helpers;
using System.Text;

namespace PCViewer.Services;
internal class ApplicationRunner : IApplicationRunner
{
    private readonly IDataStore<Computer> _dataStore;
    private readonly ComputerBuilder _computerBuilder;
    private readonly LaptopBuilder _laptopBuilder;

    public ApplicationRunner(IDataStore<Computer> dataStore, ComputerBuilder computerBuilder, LaptopBuilder laptopBuilder)
    {
        _dataStore = dataStore;
        _computerBuilder = computerBuilder;
        _laptopBuilder = laptopBuilder;
    }

    public void Run()
    {
        Console.Clear();
        // Установка выходной кодировки консоли для поддержки кириллицы (в другом случае, кириллица поддерживается не всегда)
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Приветствую в программе PCViewer, автором программы является Ян Юшков.");
        Console.WriteLine();
        Console.WriteLine("В настоящий момент вы можете собрать мою технику и затем вывести её характеристики.");

        ChooseActionDialog();
    }

    private void ChooseActionDialog()
    {
        var computers = _dataStore.GetAll();

        Console.WriteLine();
        Console.WriteLine("Выберите действие:");

        Console.WriteLine("1. Собрать мой компьютер и добавить в хранилище.");
        Console.WriteLine("2. Собрать мой ноутбук и добавить в хранилище.");
        if(computers.Any())
        {
            Console.WriteLine("3. Напечатать данные моего устройства из хранилища.");
        }
        Console.WriteLine("Или нажмите другую клавишу чтобы завершить программу.");
        Console.WriteLine();

        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine();

                if(!computers.Any(device => device.GetType() == typeof(Computer)))
                {
                     var myComputer = GetMyComputer();
                    _dataStore.Add(myComputer);
                    Console.WriteLine("Вы успешно собрали мой компьютер!");
                    ChooseActionDialog();
                    break;
                }

                Console.WriteLine("Мой компьютер уже был собран!");
                ChooseActionDialog();
                break;
            case ConsoleKey.D2:
                Console.WriteLine();

                if(!computers.Any(device => device.GetType() == typeof(Laptop)))
                {
                    var myLaptop = GetMyLaptop();
                    _dataStore.Add(myLaptop);
                    Console.WriteLine("Вы успешно собрали мой ноутбук!");
                    ChooseActionDialog();
                    break;
                }

                Console.WriteLine("Мой ноутбук уже был собран!");
                ChooseActionDialog();
                break;
            case ConsoleKey.D3:
                Console.WriteLine();

                if(!computers.Any())
                {
                    return;
                }
                
                PrintDialog();
                ChooseActionDialog();
                break;
            default:
                return;
        }
    }

    private void PrintDialog()
    {
        var computers = _dataStore.GetAll();

        Console.WriteLine();
        if(computers.Count() == 1) 
        {
            var notNullDevice = _dataStore.GetAll().First();

            Console.WriteLine($"Вы хотите вывести информацию о моем {(notNullDevice?.GetType() == typeof(Computer) ? "компьютере" : "ноутбуке")}? Д/н");
        areyousure:
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.L:
                    Console.WriteLine();
                    Console.WriteLine(notNullDevice?.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter чтобы продолжить.");
                    Console.ReadLine();
                    return;
                case ConsoleKey.Y:
                    return;
                default: 
                    Console.WriteLine("Пожалуйста, введите корректное значение, да либо нет. д для да, н для нет.");
                    goto areyousure;
            }
        }

        Console.WriteLine("Выберете действие.");
        Console.WriteLine("1. Вывести информацию о моем компьютере.");
        Console.WriteLine("2. Вывести информацию о моем ноутбуке.");
        Console.WriteLine("Или нажмите другую клавишу чтобы вернуться назад.");
        Console.WriteLine();

        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.D1:

                var computerText = _dataStore
                    .GetAll()
                    .First(device => device.GetType() == typeof(Computer))
                    .ToString();

                Console.WriteLine(computerText);
                return;

            case ConsoleKey.D2:

                var laptopText = _dataStore
                    .GetAll()
                    .First(device => device.GetType() == typeof(Laptop))
                    .ToString();

                Console.WriteLine(laptopText);
                return;

            default:
                return;
        }
    }

    private Computer GetMyComputer()
    {
        ComputerDirector.BuildComputer(_computerBuilder);
        var computer = _computerBuilder.GetResult();
        return computer;
    }

    private Laptop GetMyLaptop()
    {
        LaptopDirector.BuildLaptop(_laptopBuilder);
        var computer = _laptopBuilder.GetResult();
        return computer;
    }
}
