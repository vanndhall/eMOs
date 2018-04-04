using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMOs
{
    public partial class RaportLogon : Form
    {
        public RaportLogon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "raporty2017")
            {
                MessageBox.Show("Zalogowany!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Raport raport = new Raport();
                raport.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło, spróboj ponownie!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); 
            }
        }
    }
}
