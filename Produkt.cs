using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMOs
{
    class Produkt 
    {
        //public Panel CreatePanel()
        //{
        string liczba { get; set; }
        // }
        string produkt { get; set; }
        string mo { get; set; }
        string workcenter { get; set; }

        string id { get; set; }
        int suma { get; set; }

        int liczbastaty { get; set; }



        //static int liczbastatyczna { get; set; }

        #region KONSTRUKTORY
        public Produkt(string _produkt, string _mo, string wc, string ilosc, string pracownik, int c)
        {
            this.suma = c;
            this.produkt = _produkt;
            this.mo = _mo;
            this.workcenter = wc;
            //Convert.ToInt32(ilosc);
            //liczba = Convert.ToInt32(ilosc);// text obiektów.produkt - wyjatek wywala wartosc jest textobiektow.produkt czyli obiekt zamiast wartosci int.. do zrobienia!
            liczba = ilosc;
            id = pracownik;
        }
        public Produkt()
        {
            produkt = "";
            mo = "";
            workcenter = "";
            liczba = "";

        }

        #endregion
        public Produkt(int czasjednostki)
        {
            k = czasjednostki;

        }
        static int k;
       

        public Panel Panelproduktu(FlowLayoutPanel panelpr, Form form,Label MoLab, Label pracownik, Label operacja, Label produkt, Label czasik, Label startlab, Label stoplab, Label pracowniklab, Label czasstart,Label czasstop)
        {
            var fm = Form1.MainFormRef;
            
            // DateTime st;artdatatime = new DateTime();
            // DateTime stopdatatime = new DateTime();
            DateTime startdatatime = DateTime.Now;
            string c = startdatatime.ToString();
            
            Button Usun = new Button();
            Usun.Location = new Point(157, 66);
            Usun.Size = new Size(64, 28);
            Usun.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            Usun.ForeColor = Color.White;
            // produktlab.ImageAlign = ContentAlignment.MiddleCenter;
            Usun.TextAlign = ContentAlignment.MiddleCenter;
            Usun.BackColor = Color.ForestGreen;
            Usun.FlatStyle = FlatStyle.Flat;
            Usun.Text = "Zapisz";

            Panel panelproduktu = new Panel();
            panelproduktu.BackColor = Color.White;
            panelproduktu.Location = new Point(21, 9);
            panelproduktu.Size = new Size(224, 99);
            panelproduktu.BorderStyle = BorderStyle.FixedSingle;
            panelproduktu.Cursor = Cursors.Hand;

           
            // panelproduktu.AutoScroll = true;
            //StaticPanel penel = new StaticPanel();
            // penel.Adder(liczba);
            //penel.Adder();
            panelproduktu.Controls.Add(Usun);
            panelproduktu.Controls.Add(Itemnumber());
            
            panelproduktu.Controls.Add(Mo());
            panelproduktu.Controls.Add(Workcenter());
           // panelproduktu.Controls.Add(Ilosctekst());
            panelproduktu.Controls.Add(Ilosc(liczba));
            panelproduktu.Focus();
           // panelproduktu.Controls.Add(Datastart());

            panelproduktu.DoubleClick += delegate
            {

                if (MessageBox.Show("Jesteś pewny, że chcesz usunąć Raport?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fm.RemoveLiczbe(liczba);
                    panelpr.Controls.Remove(panelproduktu);
                }
               // suma =suma - liczba;
            };
            Itemnumber().Click += delegate
            {


                if (MessageBox.Show("Jesteś pewny, że chcesz usunąć Raport?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    panelpr.Controls.Remove(panelproduktu);

            };

            /* Usun.Click += delegate // OGARNAC TO NA JUTERO!!
             {
                // 
                 // Forma1.BazaAder(Itemnumber(),Mo(),Workcenter(),liczba, startdatatime, stopdatatime, fromTimeString, id);

                 

             };*/
            Usun.Click += delegate
            {

               // DateTime stopstring = DateTime.Now;
               // TimeSpan result2 = stopstring - startdatatime;
                
                

                 int d = k * int.Parse(liczba);

                 TimeSpan result = TimeSpan.FromSeconds(d);
                Usun.Text = result.ToString();
                Usun.Font = new Font("Microsoft Sans Serif", 8);
                Usun.TextAlign = ContentAlignment.MiddleCenter;
                string fromTimeString = result.ToString(@"hh\:mm\:ss");


                if (fromTimeString == "00:00:00")
                                {
                                    MessageBox.Show("Projekt nie może zostać dodany! Czas projektu wynosi - "+ fromTimeString+",odczekaj odpowiedni czas a następnie odśwież dane!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //panelpr.Controls.Remove(panelproduktu);
                                }
                                else {
                                    fm.BazaAder(panelproduktu,panelpr,Mo(), pracownik, Workcenter(), Itemnumber(), fromTimeString, startlab, stoplab, id, czasstart, czasstop);
                                    // form.Show();

                                }
                                //Form1 Forma = new Form1();
                                //Label T = Application.OpenForms["Form1"].Controls["MoLabsave"] as Label;
                                //Debug.WriteLine(T.Text + "dada");
                                // Panel dodawaczpanel = new Panel();
                                //  dodawaczpanel.Location = new Point(15, 7);
                                // dodawaczpanel.Size = new Size(178, 80);


                                // dodawaczpanel.BorderStyle = BorderStyle.FixedSingle;
                                // dodawaczpanel.Cursor = Cursors.Hand;

                                //Form1 FORMA = new Form1();

                                // FORMA.BazaAder("DADA");
                               
            };

            Workcenter().Click += delegate
            {

            };

            return panelproduktu;
        }

        private void Usun_Click()
        {
            
        }

        public Label Itemnumber()
        {
            Label produktlab = new Label();
            produktlab.Location = new Point(1, 5);
            produktlab.AutoSize = false;
            produktlab.Text = produkt;
            // produktlab.Enabled = false;
            produktlab.Size = new Size(220, 26);
            produktlab.ForeColor = Color.ForestGreen;
            // produktlab.ImageAlign = ContentAlignment.MiddleCenter;
            produktlab.TextAlign = ContentAlignment.MiddleCenter;
            produktlab.BackColor = Color.WhiteSmoke;
            produktlab.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
           // produktlab.Cursor = Cursors.IBeam;
          
         
            return produktlab;
        }
        private Label Mo()
        {
            Label molab = new Label();
            molab.Location = new Point(1, 35);
            molab.AutoSize = false;
            molab.Text = mo;
            //  molab.Enabled = false;
            molab.Size = new Size(218, 25);
            molab.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            molab.TextAlign = ContentAlignment.MiddleCenter;
            molab.ForeColor = Color.DarkSlateBlue;
            molab.BackColor = Color.Gainsboro;

            // molab.Cursor = Cursors.IBeam;

            return molab;


        }
        public Label Workcenter()
        {
            Label wclab = new Label();
            wclab.Location = new Point(3, 67);
            wclab.AutoSize = false;
            wclab.Text = workcenter;
            wclab.ForeColor = Color.Black;
            wclab.BackColor = Color.Gainsboro;
            // wclab.Enabled = false;
            wclab.Size = new Size(55, 27);
            wclab.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
           // wclab.Cursor = Cursors.IBeam;
            return wclab;


        }
        private Label Ilosctekst()
        {
            Label liczbatxt = new Label();
            liczbatxt.Text = "ilość:";
            liczbatxt.AutoSize = true;
            // liczbatxt.Enabled = false;
            liczbatxt.Location = new Point(61, 67);
            liczbatxt.Size = new Size(32, 13);
             liczbatxt.Font = new Font("Microsoft Sans Serif", 8);
           // liczbatxt.Cursor = Cursors.IBeam;

            return liczbatxt;
        }
        private Label Ilosc(string l) //
        {

            Label liczbaproduktow = new Label();
            liczbaproduktow.Location = new Point(61, 67);
            liczbaproduktow.Text = liczba+" pcs";
            //liczbaproduktow.AutoSize = true;
            // liczbaproduktow.Enabled = false;
            //  liczbaproduktow.Size = new Size(200, 20);
            liczbaproduktow.ForeColor = Color.Black;
            liczbaproduktow.BackColor = Color.Gainsboro;
            liczbaproduktow.TextAlign = ContentAlignment.MiddleCenter;
            // wclab.Enabled = false;
            liczbaproduktow.Size = new Size(93, 26);
            liczbaproduktow.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            liczbaproduktow.TextAlign = ContentAlignment.MiddleRight;
            //liczbaproduktow.Cursor = Cursors.IBeam;
            //StaticPanel Panelstatyczny = new StaticPanel();
            // Panelstatyczny.Adder(Convert.ToInt32(liczbaproduktow));
            return liczbaproduktow;
        }

        private Label Datastart()
        {
            Label start = new Label();
            start.Location = new Point(5, 61);
            start.Size = new Size(150, 13);
            start.Text = DateTime.Now.ToString();
            //  start.Enabled = false;

             start.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            //start.Cursor = Cursors.IBeam;


            return start;
        }

        private Label DataSTOPSTRING()
        {
            Label stopstring = new Label();
           // stopstring.Location = new Point(5, 61);
           // stopstring.Size = new Size(150, 13);
            stopstring.Text = DateTime.Now.ToString();
            //  start.Enabled = false;

            stopstring.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            //start.Cursor = Cursors.IBeam;


            return stopstring;
        }

    }
}
