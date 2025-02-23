using Timer = System.Windows.Forms.Timer;
using System.Management;
using System.Reflection;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using System;

namespace LowOnRamMeow
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private List<Cat> cats = new();
        public SoundPlayer sp;
        public static Random rand { get; private set; }
        public static MainForm Instance { get; private set; }
        public static Assembly exec { get; private set; }

        Rectangle screen = Screen.PrimaryScreen.WorkingArea;

        public MainForm()
        {
            Instance = this;
            rand = new();
            exec = Assembly.GetExecutingAssembly();
            InitializeComponent();
            InitializeTimer();
            sp = new SoundPlayer();
            //MessageBox.Show(string.Join('\n', Assembly.GetExecutingAssembly().GetManifestResourceNames()));
        }

        private void InitializeTimer()
        {
            timer = new()
            {
                Interval = 10 * 1000
            };
            timer.Tick += CheckRAM;
            timer.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckRAM(object? sender, EventArgs args)
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                ulong total = (ulong)result["TotalVisibleMemorySize"];
                ulong free = (ulong)result["FreePhysicalMemory"];
                if ((double)free / total <= 0.2) // <20%
                {
                    // MessageBox.Show(((double)free / total).ToString());
                    Cat cat = new Cat();
                    cats.Add(cat);
                    int x = rand.Next(screen.Width - cat.Width);   // range [0 .. screen width - form width].
                    int y = rand.Next(screen.Height - cat.Height); // range [0 .. screen height - form height].
                    cat.Location = new Point(x, y);
                    cat.Show();
                }
                else
                {
                    List<Cat> toRemove = new();

                    foreach (Cat cat in cats)
                    {
                        cat.Hide();
                        cat.StopTimer();
                        toRemove.Add(cat);
                    }

                    foreach (Cat cat in toRemove)
                    {
                        cats.Remove(cat);
                        cat.Dispose();
                    }

                    sp.Stop();
                }
            }
        }

        private void trayBtn_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void stopFromTray_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trayContextMenu.Show(MousePosition);
            }
        }
    }
}
