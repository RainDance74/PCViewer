using PCViewer.Contracts.Services;

namespace PCViewer.Services;
internal class ApplicationRunner : IApplicationRunner
{
    public void Run()
    {
        Console.Clear();

        Console.WriteLine("Нажмите Enter для завершения программы.");
        Console.ReadLine();
    }
}
