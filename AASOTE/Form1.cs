using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.OleDb;
using System.Diagnostics;

namespace AASOTE
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection Cameras; // Получение списка устройств
        private VideoCaptureDevice VideoSours; // Используемое устройство
        private ZXing.BarcodeReader reader;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = ..\\Debug\Работники.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        delegate void SetStringDelegate(String parameter);

        void SetResult(string result)
        {
            if (!InvokeRequired)
            {
                textBox1.Text = result;
            }
            else
            {
                Invoke(new SetStringDelegate(SetResult), new object[] { result });
            }
        }

        private void SelectDeviceButt_Click(object sender, EventArgs e)
        {
            SelectDevicesLB.Visible = true;
            SelectDeviceButt.Visible = false;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            if (data.helpMessage == false)
            {
                MessageBox.Show("При наличии нескольких устройств выберите основное до нажатия на кнопку 'Сканировать' ");
                data.helpMessage = true;
            }
            Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice); // Получаем подключенные устройства

            // Проверка на наличие камер и добавление их в listBox
            if (Cameras.Count > 0)
            {
                foreach (FilterInfo device in Cameras)
                {
                    SelectDevicesLB.Items.Add(device.Name);
                }
                SelectDevicesLB.SelectedIndex = 0;
            }

            reader = new ZXing.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>();
            reader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);
        }

        bool scan = false;

        private void ScanButt_Click(object sender, EventArgs e)
        {
            SelectDeviceButt.Hide();
            SelectDevicesLB.Hide();
            if (scan == false)
            {
                VideoSours = new VideoCaptureDevice(Cameras[SelectDevicesLB.SelectedIndex].MonikerString); // Использование выбранного устройства
                VideoSours.NewFrame += new NewFrameEventHandler(video_NewFrame);
                VideoSours.Start();
                scan = true;
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone(); // Добавляем полученную картинку в переменную bitmap
            CamScanPB.Image = bitmap; // Присваиваем полученную картинку к PicturesBox

            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
            if (result != null)
            {
                SetResult(result.Text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Завершение работы камеры
            if (VideoSours != null)
            {
                VideoSours.SignalToStop();
                VideoSours.WaitForStop();
            }
        }


        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            String comm1 = string.Format("SELECT [Имя] FROM [Сотрудники] WHERE [Код работника] = '" + textBox1.Text + "'");
            OleDbCommand com1 = new OleDbCommand(comm1, conn);
            OleDbDataAdapter ODA = new OleDbDataAdapter(com1);
            object result;

            try
            { 
                conn.Open();
                if (com1.ExecuteScalar() != null)
                {
                    result = com1.ExecuteScalar();
                    var add = result.ToString();
                    if (result != null)
                    {
                        
                        textBox3.BackColor = Color.Green;
                        textBox4.Text = add;
                        data.Cod = textBox1.Text;
                        WorkersForm WF = new WorkersForm();
                        WF.Show();
                        result = null;
                    }
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

            finally
            {
                conn.Close();
            }
            
            await Task.Delay(2000);
            textBox3.BackColor = Color.Gray;
            textBox1.Clear();
            textBox4.Clear();
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm AF = new AddForm();
            AF.Show();
        }

        private void авторизоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm AF = new AuthForm();
            AF.Show();
            this.Hide();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CamScanPB_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gray;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Gray;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\AASOTEweb\\Главная.html";
            Process.Start(path);
        }
    }
}
