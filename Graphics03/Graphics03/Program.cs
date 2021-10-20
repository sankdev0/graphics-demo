namespace OpenTK
{
    class Program
    {
        static void Main(string[] args)
        {
            MainWindow window = new MainWindow("", 800, 600);
            window.VSync = OpenTK.VSyncMode.Adaptive;
            window.Run();

        }
    }
}
