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
    public partial class PracownikLogon : Form
    {
        public PracownikLogon(string ID)
        {
            InitializeComponent();
            Dane = ID;
        }
        string Dane;
        private void txtpracolog_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyValue == (char)Keys.Return)
                {
                    if (txtpracolog.Text == Dane)
                    {
                        MessageBox.Show("Wszystko pod kontrolą!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LiderTool tool = new LiderTool(txtpracolog.Text);
                        tool.Show();
                        Close();
                    }
                }
        }
    }
}
