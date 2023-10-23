using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace AASOTE
{
    public partial class AddForm : Form
    {
        public AddForm()
        {

            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\Работники.mdb");
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comand = "INSERT INTO [Сотрудники] (Имя, Фамилия, [Код работника], Фото) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + data.imgName + "')";

            try
            {
                conn.Open();
                OleDbCommand com = new OleDbCommand(comand, conn);
                com.ExecuteNonQuery();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

            finally
            {
                conn.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Popup;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.Gray;
            BackColor = Color.FromArgb(42, 42, 42);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            pictureBox1.BackColor = Color.Gray;
            CloseL.ForeColor = Color.Red;
            data.helpMessage = true;
            BackColor.ToArgb();           
        }

        private void AddForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CloseL_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void CloseL_MouseEnter(object sender, EventArgs e)
        {
            CloseL.BackColor = Color.Aqua;
        }

        private void CloseL_MouseLeave(object sender, EventArgs e)
        {
            CloseL.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.name = textBox1.Text;
            data.surname = textBox2.Text;
            QrGenForm QGF = new QrGenForm();
            QGF.Show();
            Hide();
        }

        public async void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) // //если пользователь нажимает в обозревателе кнопку "Открыть".
            {
                pictureBox1.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.
                string path = Environment.CurrentDirectory + "\\Photo" + "\\" + load.SafeFileName;
                data.imgName = "Photo" + "\\" + load.SafeFileName;
                await Task.Delay(2000);
                pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.CF.Show();
        }
    }
}
