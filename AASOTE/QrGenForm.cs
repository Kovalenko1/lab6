using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace AASOTE
{
    public partial class QrGenForm : Form
    {
        public QrGenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text; //считываем текст из TextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаём новую "генерацию кода"
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Открыть".
            {
                pictureBox1.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.
            }
            QRCodeDecoder decoder = new QRCodeDecoder(); // создаём "раскодирование изображения"
            textBox1.Text = decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string Cod = "";
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                Cod = Cod + arr[rnd.Next(0, 57)];

            }
            textBox1.Text = Cod;
            string qrtext = textBox1.Text; //считываем текст из TextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаём новую "генерацию кода"
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            data.AF.textBox3.Text = textBox1.Text;
            Close();
        }

        private void QrGenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.AF.Show();
            data.AF.textBox1.Text = data.name;
            data.AF.textBox2.Text = data.surname;
        }

        private void QrGenForm_Load(object sender, EventArgs e)
        {
            // Визуал
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
            button5.FlatStyle = FlatStyle.Popup;
            button5.FlatAppearance.BorderSize = 0;
            button5.BackColor = Color.Gray;
            BackColor = Color.FromArgb(42, 42, 42);
            label1.ForeColor = Color.White;
            // 
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Aqua;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QrGenForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Перемещениие формы
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            //
        }
    }
}
