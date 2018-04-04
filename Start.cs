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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

        }
        //static int oknaotwarte = 0;
        static bool czyotwarteform1 = false;
        static bool czyotwartelider = false;
        static bool czyotwarteraport = false;

        public Start(bool form1)
        {
            czyotwarteform1 = form1;


        }
        public Start(bool lider, double i)
        {
            czyotwartelider = lider;
        }
        public Start(bool raport, int i)
        {
            czyotwarteraport = raport;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (czyotwarteform1 == false)
            {
                Form1 forma = new Form1();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Zamknij aktualne okno 'Czas pracy' aby otworzyć kolejne!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            czyotwarteform1 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                RaportLogon raport = new RaportLogon();
                raport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                LiderLogin login = new LiderLogin();
                login.Show(); 
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (czyotwarteform1 == true)
            {
                var ok = MessageBox.Show("Zamknij okno 'Czas pracy' aby zamknąć aplikacje!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ok == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (czyotwarteraport == true)
            {
                var ok = MessageBox.Show("Zamknij okno 'Raport' aby zamknąć aplikacje!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ok == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (czyotwartelider == true)
            {
                var ok = MessageBox.Show("Zamknij okno 'LiderTool' aby zamknąć aplikacje!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ok == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }

            else
            {
                var res = MessageBox.Show(this, "Czy na pewno zamknąć aplikacje?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }



            }
        }
    }
}
