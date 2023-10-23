using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AASOTE
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "работникиDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.работникиDataSet.Сотрудники);

            button1.FlatStyle = FlatStyle.Popup;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Gray;
            BackColor = Color.FromArgb(42, 42, 42);
            label1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                работникиTableAdapter.Update(работникиDataSet);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                сотрудникиBindingSource.Filter = "[Фамилия] LIKE'" + textBox1.Text + "%'";
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Aqua;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void ChangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
