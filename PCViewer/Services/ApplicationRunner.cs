using PCViewer.Contracts.Services;
using PCViewer.Core.Models;
using PCViewer.Helpers;
using System.Text;

namespace PCViewer.Services;
internal class ApplicationRunner : IApplicationRunner
{
    private readonly ComputerBuilder _computerBuilder;
    private readonly LaptopBuilder _laptopBuilder;

    private Computer? myComputer;
    private Laptop? myLaptop;

    public ApplicationRunner(ComputerBuilder computerBuilder, LaptopBuilder laptopBuilder)
    {
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
        Console.WriteLine();
        Console.WriteLine("Выберите действие:");

        Console.WriteLine("1. Собрать мой компьютер.");
        Console.WriteLine("2. Собрать мой ноутбук.");
        if(myComputer is not null || myLaptop is not null)
        {
            Console.WriteLine("3. Напечатать данные моего устройства.");
        }
        Console.WriteLine("Или нажмите другую клавишу чтобы завершить программу.");
        Console.WriteLine();

        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine();

                if(myComputer is null)
                {
                    myComputer = GetMyComputer();
                    Console.WriteLine("Вы успешно собрали мой компьютер!");
                    ChooseActionDialog();
                    break;
                }

                Console.WriteLine("Мой компьютер уже был собран!");
                ChooseActionDialog();
                break;
            case ConsoleKey.D2:
                Console.WriteLine();

                if(myLaptop is null)
                {
                    myLaptop = GetMyLaptop();
                    Console.WriteLine("Вы успешно собрали мой ноутбук!");
                    ChooseActionDialog();
                    break;
                }

                Console.WriteLine("Мой ноутбук уже был собран!");
                ChooseActionDialog();
                break;
            case ConsoleKey.D3:
                Console.WriteLine();

                if(myComputer is null && myLaptop is null)
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
        Console.WriteLine();
        if(myComputer is null || myLaptop is null) 
        {
            var notNullDevice = myComputer ?? myLaptop;

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
                Console.WriteLine(myComputer.ToString());
                return;
            case ConsoleKey.D2:
                Console.WriteLine(myLaptop.ToString());
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
