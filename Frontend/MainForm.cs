using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ImageNST
{
    public partial class MainForm : Form
    {
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;

        private string appPath = Application.StartupPath;
        private bool isTraining = false;

        private Process p = new Process();

        private OpenFileDialog openContent = new OpenFileDialog
        {
            InitialDirectory = Application.StartupPath,
            Filter = "Image (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg",
            FilterIndex = 0,
            RestoreDirectory = true
        };

        private SaveFileDialog saveOutput = new SaveFileDialog
        {
            FileName = "output.jpg",
            Filter = "Image (*.jpg)|*.jpg;"
        };

        public MainForm()
        {
            InitializeComponent();
            IgnoreDPI();
        }





        public static int IgnoreDPI()
        {
            SetProcessDPIAware();
            IntPtr screenDC = GetDC(IntPtr.Zero);
            int dpi_x = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSX);
            int dpi_y = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSY);
            ReleaseDC(IntPtr.Zero, screenDC);

            return dpi_x;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(
        IntPtr hdc, // handle to DC
        int nIndex // index of capability
        );

        [DllImport("user32.dll")]
        internal static extern bool SetProcessDPIAware();

        const int LOGPIXELSX = 88;
        const int LOGPIXELSY = 90;

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void GithubBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xAsiimov/ImageNST");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (File.Exists(appPath + "/Backend/Main.py") && File.Exists(appPath + "/Backend/Image.py") && File.Exists(appPath + "/Backend/Model.py"))
            {
                if (!Directory.Exists(appPath + "/Backend/input/"))
                {
                    Directory.CreateDirectory(appPath + "/Backend/input/");
                }
                else
                {
                    if (File.Exists(appPath + "/Backend/input/content.jpg"))
                    {
                        ContentBox.ImageLocation = appPath + "/Backend/input/content.jpg";
                    }

                    if (File.Exists(appPath + "/Backend/input/style.jpg"))
                    {
                        StyleBox.ImageLocation = appPath + "/Backend/input/style.jpg";
                    }
                }
            }
            else
            {
                StatusLabel.Text = "No Python Backend Found";
                AddContent.Enabled = false;
                AddStyle.Enabled = false;
                Train.Enabled = false;
                SaveOutput.Enabled = false;
            }

        }

        private void AddContent_Click(object sender, EventArgs e)
        {
            if (openContent.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openContent.FileName;

                if (File.Exists(appPath + "/Backend/input/content.jpg"))
                {
                    File.Delete(appPath + "/Backend/input/content.jpg");
                }

                File.Copy(selectedFileName, appPath + "/Backend/input/content.jpg");
                ContentBox.ImageLocation = selectedFileName;
            }
        }

        private void AddStyle_Click(object sender, EventArgs e)
        {
            if (openContent.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openContent.FileName;

                if (File.Exists(appPath + "/Backend/input/style.jpg"))
                {
                    File.Delete(appPath + "/Backend/input/style.jpg");
                }

                File.Copy(selectedFileName, appPath + "/Backend/input/style.jpg");
                StyleBox.ImageLocation = selectedFileName;
            }
        }

        private async void Train_Click(object sender, EventArgs e)
        {
            if (!isTraining)
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "python";
                p.StartInfo.WorkingDirectory = appPath + "/backend";
                p.StartInfo.Arguments = "Main.py";
                p.StartInfo.CreateNoWindow = true;

                Train.Text = "Interrupt Training";
                isTraining = true;
                p.Start();
                PythonBackend.AppendText("Start Training. It may take a few minutes.\n");
                PythonBackend.AppendText(Environment.NewLine);
                string line;
                while ((line = await p.StandardOutput.ReadLineAsync()) != null)
                {
                    PythonBackend.AppendText(line);
                    PythonBackend.AppendText(Environment.NewLine);
                }

                if (File.Exists(appPath + "/Backend/output/output.jpg"))
                {
                    OutputBox.ImageLocation = appPath + "/Backend/output/output.jpg";
                }

                Train.Enabled = true;
            }
            else
            {
                Train.Text = "Train Model";
                PythonBackend.AppendText("User Interrupt.");
                PythonBackend.AppendText(Environment.NewLine);
                p.Kill();
                isTraining = false;
            }
        }


        private void SaveOutput_Click(object sender, EventArgs e)
        {
            if (File.Exists(appPath + "/Backend/output/output.jpg"))
            {
                if (saveOutput.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(appPath + "/Backend/output/output.jpg", saveOutput.FileName);
                }
            }
        }
    }
}

