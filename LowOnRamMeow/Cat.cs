using System.IO;
using System.Media;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;

namespace LowOnRamMeow
{
    public partial class Cat : Form
    {
        Timer soundTimer;
        Random rand;
        Assembly exec;

        public Cat()
        {
            InitializeComponent();
            rand = MainForm.rand;
            exec = MainForm.exec;
        }

        public void StopTimer()
        {
            soundTimer.Stop();
        }

        private void Cat_Load(object sender, EventArgs e)
        {
            string imgName = $"LowOnRamMeow.cat{Math.Clamp(rand.Next(1, 6), 1, 6)}.png";

            // MessageBox.Show(string.Join("\n", exec.GetManifestResourceNames()) + "\n" +$"My resource: {resName}");

            
#pragma warning disable CS8604 // ¬озможно, аргумент-ссылка, допускающий значение NULL.
            pic.Image = Image.FromStream(
                exec.GetManifestResourceStream(imgName));
#pragma warning restore CS8604 // ¬озможно, аргумент-ссылка, допускающий значение NULL.

            // play sound on interval
            soundTimer = new Timer();
            soundTimer.Interval = rand.Next(1000, 6000);
            soundTimer.Tick += Timer_Tick;
            soundTimer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            lock (MainForm.Instance.sp)
            {
                MainForm.Instance.sp.Stream = exec.GetManifestResourceStream($"LowOnRamMeow.meow{Math.Clamp(rand.Next(1, 5), 1, 4)}.wav");
                MainForm.Instance.sp.PlaySync();
            }
        }
    }
}
