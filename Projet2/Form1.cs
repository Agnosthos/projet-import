using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2
{
    public partial class Form1 : Form
    {
        //attribut
        public static MySqlConnection objConnect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string host = "localhost";
            string database = "import";
            string username = "root";
            string password = "root";

            String connString = "Server=" + host + ";Database=" + database + ";User Id=" + username + ";password=" + password;
            try
            {
                objConnect = new MySqlConnection(connString);
                objConnect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb d'acces a la base" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
            textBox1.Text = OpenFileDialog.FileName;

        }
    }
}
