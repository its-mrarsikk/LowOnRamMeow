namespace LowOnRamMeow
{
    internal static class Program
    {
        static List<Cat> cats = [];


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void CheckRAMUsage()
        {
            // todo: implement ram check
                Cat cat = new Cat();
                cats.Add(cat);
                cat.Show();
        }
    }
}