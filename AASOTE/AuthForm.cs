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

namespace AASOTE
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\Работники.mdb");
        
        private void AuthButt_Click(object sender, EventArgs e)
        {
            try
            {
                string comand = string.Format("Select * From Администраторы WHERE Логин='" + LoginTextBox.Text + "'"
                    + "AND Пароль='" + PasswordTextBox.Text + "'");
                OleDbCommand check = new OleDbCommand(comand, conn);
                conn.Open();

                if (check.ExecuteScalar() != null)
                {
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.авторизоватьсяToolStripMenuItem.Visible = false;
                    f1.добавитьПользователяToolStripMenuItem.Visible = true;
                    f1.Show();
                }

                else
                {
                    MessageBox.Show("Неверный логин или пороль");
                }

            }
            finally
            {
                conn.Close();
            }
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AuthForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            AuthButt.FlatStyle = FlatStyle.Popup;
            AuthButt.FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(42, 42, 42);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            AuthButt.BackColor = Color.Gray;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Aqua;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int x;
	    string xxx;
            this.Close();
        }
    }
}
