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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = ..\\Debug\Работники.mdb");
        OleDbCommand comm1;

        private async void WorkersForm_Load(object sender, EventArgs e)
        {
            Activate();
            string txt;
            
            BackColor = Color.FromArgb(42, 42, 42);
            Form1 f1 = new Form1();
            comm1 = conn.CreateCommand();
            comm1.CommandText = "SELECT * FROM [Сотрудники] WHERE [Код работника] = '" + data.Cod + "'";

            try
            {
                conn.Open();
                OleDbDataReader reader = comm1.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetValue(1).ToString();
                    label2.Text = reader.GetValue(2).ToString();
                    label3.Text = reader.GetValue(3).ToString();
                    txt = reader.GetValue(4).ToString();
                    pictureBox1.Image = new Bitmap (txt);
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
            await Task.Delay(10000);
            Close();
        }

        private void WorkersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.f1.Activate();
        }
    }
}
