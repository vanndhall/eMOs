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
    public partial class Form1 : Form
    {
        static string d;
        static int liczbazwrotna;
        public static  Form1 MainFormRef{ get; private set; }
        public Form1()
        {
            
            InitializeComponent();
            MainFormRef = this;
            
            //MoLabsave.Text = "0";
        }
        public Form1(string c)
        {
            d = c;
            MoLabsave.Text = d;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emosDataSet1.MoOperacje' table. You can move, or remove it, as needed.
            this.moOperacjeTableAdapter.Fill(this.emosDataSet1.MoOperacje);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "Czy chcesz zakończyć aplikacje? Uwaga wszystkie niezapisane raporty zostaną utracone!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                
                
                e.Cancel = true;
                
                return;
            }
            bool oknootwarte = false;
            Start menu = new Start(oknootwarte);

        }
        public int Liczbasumy(int i)
        {
            int j = i;
            return j;
            
        }
        #region Panel Głowny - METODA
        public Panel Glowny()
        {
            #region zmienne statyczne
            bool czydodaj = false;
            bool czystart = false;
            int c = 0;
            string ID;
            #endregion
            #region Interfejsik
            CheckBox checkadder = new CheckBox();
            checkadder.Location = new Point(163, 81);
            checkadder.Size = new Size(15, 14);
            checkadder.Checked = true;


            CheckBox checkstatic = new CheckBox();
            checkstatic.Location = new Point(180, 81);
            checkstatic.Size = new Size(15, 14);
            checkstatic.Checked = false;

            //CreateDodaj();  206; 3
            Button Dodaj = new Button();
            Dodaj.Location = new Point(4, 62);
            Dodaj.Text = "Dodaj";
            //return Dodaj;
            Dodaj.Focus();

            Button X = new Button(); // BUTTON DO ZAMKNIECIA CALEGO PANELA UZYTKOWNIKA
            X.Location = new Point(208, 2);
            X.Text = "X";
            X.Size = new Size(21, 21);
            X.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

            //BUTON USUN W INTERFEJSIE___________________________________________________________
            //  Button Usun = new Button();
            // Usun.Location = new Point(129, 61);
            //Usun.Text = "Zakończ";

            //LABEL IMIE I NAZWISKO PRACOWNIKA___________________________________________________
            Label pracownik = new Label();
            pracownik.Location = new Point(15, 24);
            pracownik.Text = "";
            //pracownik.TextAlign = ContentAlignment.MiddleLeft;
            // pracownik.Enabled = false;
            //pracownik.AutoSize = true;
           
            pracownik.Size = new Size(160, 50);
            pracownik.ForeColor = Color.Black;
            pracownik.BackColor = Color.Transparent;
            pracownik.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);




            //Interfejsik czyli Panel w ktorym bd znajdować się takie obiekty jak Pracownik = Label, 2butony na poczatek oraz zmiennna IDracownika do zamiany ID na Nazwisko Pracownika
            Panel Interfejsik = new Panel();
            Interfejsik.Location = new Point(3, 6);
            Interfejsik.Size = new Size(199, 99);
            Interfejsik.BorderStyle = BorderStyle.None;
            Interfejsik.Cursor = Cursors.Hand;
            Interfejsik.BackColor = Color.White;
            Interfejsik.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            Interfejsik.BackgroundImage = Properties.Resources.logo;
            Interfejsik.BackgroundImageLayout = ImageLayout.Stretch;
            // Interfejsik.AutoScroll = true;


            Interfejsik.Controls.Add(pracownik);
            Interfejsik.Controls.Add(checkadder);
            Interfejsik.Controls.Add(checkstatic);
           // Interfejsik.Controls.Add(X);

            #endregion
            #region StatycznyPanel
            // int c = +L;

            //string _start,string _stop,string _czas,string _jednostka



            Panel statyczny = new Panel();
            statyczny.Location = new Point(496, 6);
            statyczny.Size = new Size(305, 99); 
            statyczny.BorderStyle = BorderStyle.FixedSingle;
           // statyczny.Cursor = Cursors.Hand;
            statyczny.BackColor = Color.White;
            //statyczny.Visible = false;
            // statyczny.AutoScroll = true;

            CheckBox checkdluga = new CheckBox();
            checkdluga.Location = new Point(230, 2);
            checkdluga.Text = "20 minut";
            //checkdluga.Size = new Size(15, 14);
            


            CheckBox checkkrotka = new CheckBox();
            checkkrotka.Location = new Point(230, 21);
            checkkrotka.Text = "10 minut";
            //checkkrotka.Size = new Size(15, 14);
            


            //________________________________
            Button startstaticbtn = new Button();
            startstaticbtn.Location = new Point(156, 9);
            startstaticbtn.Text = "Start";
            startstaticbtn.Visible = false;
            //______________________________________
            Button stopstaticbtn = new Button();
            stopstaticbtn.Location = new Point(230, 45);
            stopstaticbtn.Text = "Odśwież";
            stopstaticbtn.Size = new Size(70, 50);
            stopstaticbtn.Visible = false;
            stopstaticbtn.ForeColor = Color.Black;
            stopstaticbtn.BackColor = Color.White;

            Label sumatxt = new Label();
            sumatxt.Location = new Point(2, 72);
            sumatxt.Text = "Ilość:";
            // produktlab.Enabled = false;
            //sumatxt.Size = new Size(32, 13);
            sumatxt.ForeColor = Color.Red;
            sumatxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            sumatxt.Cursor = Cursors.IBeam;

            Label suma = new Label();
            suma.Location = new Point(88, 72);
            suma.Text = c.ToString();
            // produktlab.Enabled = false;
            suma.Size = new Size(102, 16);
            suma.TextAlign = ContentAlignment.MiddleRight;
            suma.ForeColor = Color.Red;
            suma.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //suma.Cursor = Cursors.IBeam;

            Label czasjednostkitxt = new Label();
            czasjednostkitxt.Location = new Point(2, 54);
            czasjednostkitxt.Text = "Czas jednostki:";
            //  molab.Enabled = false;
            czasjednostkitxt.Size = new Size(78, 13);
            czasjednostkitxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //czasjednostkitxt.Cursor = Cursors.IBeam;


            Label czasjednostki = new Label();
            czasjednostki.Location = new Point(146, 53);
            czasjednostki.Text = "";
            //  molab.Enabled = false;
            czasjednostki.TextAlign = ContentAlignment.MiddleRight;
            czasjednostki.Size = new Size(44, 16);
            czasjednostki.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czasjednostki.BackColor = Color.Transparent;
            //  molab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            // czasjednostki.Cursor = Cursors.IBeam;


            Label czasstart = new Label();
            czasstart.Location = new Point(48, 4);
            czasstart.Text = "";
            // wclab.Enabled = false;
            czasstart.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czasstart.Size = new Size(142, 16);
            // wclab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //czasstart.Cursor = Cursors.IBeam;

            Label czasstop = new Label();
            czasstop.Text = "";
            // liczbatxt.Enabled = false;
            czasstop.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czasstop.Location = new Point(49, 20);
            czasstop.Size = new Size(142, 16);
            // liczbatxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
           // czasstop.Cursor = Cursors.IBeam;



            Label czasprojektu = new Label();
            czasprojektu.Location = new Point(126, 37);
            czasprojektu.Text = "";
            czasprojektu.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czasprojektu.TextAlign = ContentAlignment.MiddleRight;
            czasprojektu.Size = new Size(64, 16);
            // liczbaproduktow.Enabled = false;
            //  liczbaproduktow.Size = new Size(200, 20);
            // liczbaproduktow.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
           // czasprojektu.Cursor = Cursors.IBeam;




            Label czastxt = new Label();
            czastxt.Location = new Point(2, 38);
            czastxt.Text = "Czas projektu:";
            //  start.Enabled = false;
           czastxt .Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czastxt.Size = new Size(99, 15);
            // start.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            czastxt.Cursor = Cursors.IBeam;




            Label starttxt = new Label();
            starttxt.Location = new Point(2,3);
            starttxt.Text = "Start:";
            //  start.Enabled = false;
            starttxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            starttxt.Size = new Size(41, 15);
            // start.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
           // starttxt.Cursor = Cursors.IBeam;



            Label stoptxt = new Label();
            stoptxt.Location = new Point(2,22);
            stoptxt.Text = "Stop:";
            //  start.Enabled = false;
            stoptxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            stoptxt.Size = new Size(40, 15);
            // start.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            stoptxt.Cursor = Cursors.IBeam;


            //Add(liczbastatyczna);
            statyczny.Controls.Add(sumatxt);
            statyczny.Controls.Add(suma);
            statyczny.Controls.Add(czasjednostkitxt);
            statyczny.Controls.Add(czasjednostki);
            statyczny.Controls.Add(czasstart);
            statyczny.Controls.Add(czasstop);
            statyczny.Controls.Add(czasprojektu);
            statyczny.Controls.Add(czastxt);
            statyczny.Controls.Add(starttxt);
            statyczny.Controls.Add(stoptxt);
            statyczny.Controls.Add(checkdluga);
            statyczny.Controls.Add(checkkrotka);
            statyczny.Controls.Add(stopstaticbtn);
            dodajIDtxt.Focus();

            #endregion
            #region Flowproduktpanel Panel w ktorym znajduja sie panele produktów

            // statyczny.Location = new Point(502, 6);
            //statyczny.Size = new Size(305, 99);
            FlowLayoutPanel Flowproduktypanel = new FlowLayoutPanel();
            //Flowproduktypanel.Location = new Point(809, 6);
            Flowproduktypanel.Size = new Size(460, 105);
            
            Flowproduktypanel.BorderStyle = BorderStyle.None;
            Flowproduktypanel.Cursor = Cursors.Hand;
            Flowproduktypanel.AutoSize = true;
            
            Flowproduktypanel.FlowDirection = FlowDirection.LeftToRight;
            Flowproduktypanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flowproduktypanel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            Flowproduktypanel.WrapContents = true;
            Flowproduktypanel.BackColor = Color.Transparent;
            

            FlowLayoutPanel Flowprodukty = new FlowLayoutPanel();
            Flowprodukty.Location = new Point(809, 0);
            Flowprodukty.Size = new Size(237, 183);
            Flowprodukty.AutoSize = true;
            
            Flowprodukty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flowprodukty.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            Flowprodukty.BorderStyle = BorderStyle.None;
            Flowprodukty.FlowDirection = FlowDirection.LeftToRight;
            Flowprodukty.Cursor = Cursors.Hand;
            //Flowprodukty.AutoScroll = true;
            Flowprodukty.BackColor = Color.Transparent;
            Flowprodukty.WrapContents = true;
            Flowprodukty.Controls.Add(Flowproduktypanel);
            // Flowprodukty.Visible = false;
           // Flowproduktypanel.Enabled = false;

            #endregion
            #region Produkt

            Button delete = new Button();
            delete.Location = new Point(146, 4);
            delete.Size = new Size(61, 23);
            delete.Text = "Zakończ";


            // panelproduktu.AutoScroll = true;


            //Nazwa produktu_____________________________________________________________________
            Label produktlab = new Label();
            produktlab.Location = new Point(5, 14);
            produktlab.Text = "XBUL 11C";
            // produktlab.Enabled = false;
            // produktlab.Size = new Size(80, 20);
            produktlab.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            produktlab.Cursor = Cursors.IBeam;

            //Numer MO____________________________________________________________________________
            Label molab = new Label();
            molab.Location = new Point(6, 38);
            molab.Text = "4089503";
            //  molab.Enabled = false;
            molab.Size = new Size(55, 13);
            //  molab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            molab.Cursor = Cursors.IBeam;

            //Numer Workcenter____________________________________________________________________
            Label wclab = new Label();
            wclab.Location = new Point(97, 38);
            wclab.Text = "C01";
            // wclab.Enabled = false;
            wclab.Size = new Size(32, 13);
            // wclab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            wclab.Cursor = Cursors.IBeam;

            //Lczba________________________________________________________________________________
            Label liczbatxt = new Label();
            liczbatxt.Text = "ilość:";
            // liczbatxt.Enabled = false;
            liczbatxt.Location = new Point(155, 38);
            liczbatxt.Size = new Size(32, 13);
            // liczbatxt.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            liczbatxt.Cursor = Cursors.IBeam;

            Label liczbaproduktow = new Label();
            liczbaproduktow.Location = new Point(174, 61);
            liczbaproduktow.Text = "54";
            // liczbaproduktow.Enabled = false;
            //  liczbaproduktow.Size = new Size(200, 20);
            // liczbaproduktow.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            liczbaproduktow.Cursor = Cursors.IBeam;

            Label startprodukt = new Label();
            startprodukt.Location = new Point(5, 61);
            startprodukt.Text = "2017-06-06 14:20:11";
            //  start.Enabled = false;
            //  start.Size = new Size(200, 20);
            // start.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            startprodukt.Cursor = Cursors.IBeam;

            Panel panelproduktu = new Panel();
            panelproduktu.Location = new Point(21, 9);
            panelproduktu.Size = new Size(210, 84);
            panelproduktu.BorderStyle = BorderStyle.FixedSingle;
            panelproduktu.Cursor = Cursors.Hand;
            panelproduktu.BackColor = Color.White;

            panelproduktu.Controls.Add(delete);
            panelproduktu.Controls.Add(produktlab);
            panelproduktu.Controls.Add(molab);
            panelproduktu.Controls.Add(wclab);
            panelproduktu.Controls.Add(liczbatxt);
            panelproduktu.Controls.Add(liczbaproduktow);
            panelproduktu.Controls.Add(startprodukt);
            //panelproduktu.Enabled = false;








            #endregion
            #region AddPanel

            Panel panelAder = new Panel();
            panelAder.Location = new Point(207, 6);
            panelAder.Size = new Size(285, 99);
            panelAder.BorderStyle = BorderStyle.None;
           // panelAder.Cursor = Cursors.Hand;
            panelAder.BackColor = Color.White;
           // panelAder.Visible = false;
            panelAder.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

           //__________________________________________________________
            Label PracoLab = new Label();
            PracoLab.Location = new Point(38, 11);
            PracoLab.Text = "ID:";
            PracoLab.Size = new Size(21, 13);
            //ProduktlabADD.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //PracoLab.Cursor = Cursors.IBeam;
            PracoLab.Visible = false;
           

            Label ProduktlabADD = new Label();
            ProduktlabADD.Location = new Point(6, 6);
            ProduktlabADD.Text = "Produkt:";
            ProduktlabADD.AutoSize = true;
            //ProduktlabADD.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //ProduktlabADD.Cursor = Cursors.IBeam;
           // ProduktlabADD.Visible = false;

          

            Label MOtlabADD = new Label();
            MOtlabADD.Location = new Point(6, 28);
            MOtlabADD.Text = "MO:";
            MOtlabADD.AutoSize = true;
            // MOtlabADD.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //MOtlabADD.Cursor = Cursors.IBeam;
           // MOtlabADD.Visible = false;

            Label OperacjalabADD = new Label();
            OperacjalabADD.Location = new Point(6, 50);
            OperacjalabADD.Text = "Operacja:";
            OperacjalabADD.AutoSize = true;
            //OperacjalabADD.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
           // OperacjalabADD.Cursor = Cursors.IBeam;
            //OperacjalabADD.Visible = false;

            Label IlosctlabADD = new Label();
            IlosctlabADD.Location = new Point(6, 76);
            IlosctlabADD.Text = "Ilość:";
            IlosctlabADD.AutoSize = true;
            //IlosctlabADD.ForeColor = Color.Red;
            //  produktlab.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
           // IlosctlabADD.Cursor = Cursors.IBeam;
            //IlosctlabADD.Visible = false;

           //__________________________________________________________
            TextBox idpracownikatxxt = new TextBox();
            idpracownikatxxt.Location = new Point(62, 4);
            idpracownikatxxt.Size = new Size(90, 20);
           // idpracownikatxxt.Visible = false;
            idpracownikatxxt.PasswordChar = '*';
           

            TextBox produktaddtxt = new TextBox();
            produktaddtxt.Location = new Point(71, 3);
            produktaddtxt.Size = new Size(159, 20);
            //produktaddtxt.Visible = false;
            

            TextBox moaddtxt = new TextBox();
            moaddtxt.Location = new Point(71, 25);
            moaddtxt.Size = new Size(159, 20);
            //moaddtxt.Visible = false;

            TextBox operacjaaddtxt = new TextBox();
            operacjaaddtxt.Location = new Point(71, 47);
            operacjaaddtxt.Size = new Size(159, 20);
           // operacjaaddtxt.Visible = false;

           // TextBox c = new TextBox();
            NumericUpDown piloscaddtxt = new NumericUpDown();
           // TextBox piloscaddtxt = new TextBox();
            piloscaddtxt.Location = new Point(71, 69);
            piloscaddtxt.Size = new Size(159, 20);
            //piloscaddtxt.Visible = false;
            piloscaddtxt.Maximum = 2000;
            piloscaddtxt.Minimum = 1;

            Button Add = new Button();
            Add.Location = new Point(236, 3);
            Add.Size = new Size(46, 86);
            Add.Text = "Dodaj";
            //Add.Visible = false;

            //_________________________________
            Button zakoncz = new Button();
            zakoncz.Location = new Point(158, 48);
            zakoncz.Size = new Size(75, 20);
            zakoncz.Text = "Zakończ";
            zakoncz.Visible = true;
           

            //panelAder.Controls.Add(PracoLab);
           // panelAder.Controls.Add(idpracownikatxxt);
            panelAder.Controls.Add(ProduktlabADD);
            panelAder.Controls.Add(MOtlabADD);
            panelAder.Controls.Add(OperacjalabADD);
            panelAder.Controls.Add(IlosctlabADD);
            panelAder.Controls.Add(produktaddtxt);
            panelAder.Controls.Add(moaddtxt);
            panelAder.Controls.Add(operacjaaddtxt);
            panelAder.Controls.Add(piloscaddtxt);
            panelAder.Controls.Add(Add);
           // panelAder.Controls.Add(zakoncz);
            DateTime startdata = DateTime.Now;
            produktaddtxt.Focus();



            #endregion
            #region Panel Glowny
            // Produkt panelProduktu = new Produkt();
            // StaticPanel panelStatyczny = new StaticPanel();
            Panel startpanel = new Panel();
            //startpanel.Size = new Size(1127, 113);
            startpanel.AutoSize = true;
            startpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            startpanel.AutoScroll = false;
            //startpanel.FlowDirection = FlowDirection.LeftToRight;
            startpanel.Anchor = (AnchorStyles.Top| AnchorStyles.Left);
            startpanel.BorderStyle = BorderStyle.FixedSingle;
            //startpanel.BackColor = Color.DarkRed;
            startpanel.BackgroundImage = Properties.Resources._112;
            startpanel.BackgroundImageLayout = ImageLayout.Tile;
           // startpanel.Cursor = Cursors.Hand;
           // startpanel.BackColor = Color.Azure;
            // startpanel.AutoScroll = true;

            // startpanel.Controls.Add(Usun);
            // startpanel.Controls.Add(Dodaj);


            startpanel.Controls.Add(Interfejsik);
            startpanel.Controls.Add(statyczny); // to dziala
            startpanel.Controls.Add(panelAder);
            startpanel.Controls.Add(Flowprodukty); // 
            

            #endregion
            #region Autoryzacja pracownika
            try
            {
                emosDataSet1TableAdapters.PracownicyTableAdapter user = new emosDataSet1TableAdapters.PracownicyTableAdapter();
                emosDataSet1.PracownicyDataTable dt = user.Login(dodajIDtxt.Text);
                if (dt.Rows.Count > 0)
                {
                    
                    pracownik.Text = dt.Rows[0]["pr_Imie"].ToString() + " " + dt.Rows[0]["pr_Nazwisko"].ToString();

                    flowLayoutPanel1.Controls.Add(startpanel);
                    
                    checkadder.Checked = true;
                    checkstatic.Checked = false;
                    if (checkadder.CheckState == CheckState.Checked && checkstatic.CheckState == CheckState.Unchecked)//1,0
                    {
                        panelAder.Visible = true;
                        statyczny.Visible = false;
                        panelAder.Location = new Point(207, 6);
                        //statyczny.Location = new Point(207, 6);
                        Flowprodukty.Location = new Point(496, 0);
                        produktaddtxt.Focus();
                    }
                    


                }
                //else
                // { MessageBox.Show("Taki pracownik nie istnieje!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            ID = dodajIDtxt.Text;
            dodajIDtxt.Clear();
            produktaddtxt.Focus();

            #endregion

            #region Metody buttonów
            //METODY BUTTONÓW_______________________________________________
            pracownik.DoubleClick += delegate
            {
                if (MessageBox.Show("Zakończyć prace pracownika " + pracownik.Text + "  ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    flowLayoutPanel1.Controls.Remove(startpanel);
                }
                dodajIDtxt.Focus();
            };
            startstaticbtn.Click += delegate
            {
                startdata = DateTime.Now;
                czasstart.Text = startdata.ToString();
                startstaticbtn.Visible = false;

                startpanel.BackColor = Color.DarkGreen;
                pracownik.ForeColor = Color.DarkGreen;
                stopstaticbtn.Visible = true;

            };
            stopstaticbtn.Click += delegate
            {
                int przerwa = 0;
                if (checkdluga.CheckState == CheckState.Checked && checkkrotka.CheckState == CheckState.Checked)// 1,1
                {
                    int przerwabardzodluga = 1800;
                    przerwa = przerwabardzodluga;
                }
                if (checkdluga.CheckState == CheckState.Unchecked && checkkrotka.CheckState == CheckState.Checked)//0,1
                {
                    int przerwakrotka = 600;
                    przerwa = przerwakrotka;
                    
                }
                if (checkdluga.CheckState == CheckState.Checked && checkkrotka.CheckState == CheckState.Unchecked)//1,0
                {
                    int przerwadluga = 1200;
                    przerwa = przerwadluga;
                }
                if (checkdluga.CheckState == CheckState.Unchecked && checkkrotka.CheckState == CheckState.Unchecked)//0,0
                {
                    int brakprzerwy = 0;
                    przerwa = brakprzerwy;
                }

                c = c - liczbazwrotna;
                suma.Text = c.ToString();
                liczbazwrotna = 0;
                //BazaAder();
                czasstop.Text = DateTime.Now.ToString();

                TimeSpan timeDiff = DateTime.Now - startdata;
                czasprojektu.Text = timeDiff.ToString(@"hh\:mm\:ss");

                double wynik = (double)timeDiff.TotalSeconds;
                wynik = wynik - przerwa;
                if (wynik<0)
                {
                    MessageBox.Show("Musi minąć dłuższy czas projektu niż czas przerwy! Przerwa zostanie odznaczona automatycznie", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkdluga.CheckState = CheckState.Unchecked;
                    checkkrotka.CheckState = CheckState.Unchecked;
                    
                }
                if (c > 0 && wynik>0)
                {
                    double wynik1 = ((double)wynik) / c;


                    int wynik2 = (int)Math.Round(wynik1);
                    czasjednostki.Text = wynik2.ToString();
                    Produkt pro = new Produkt(wynik2);
                    statyczny.BackColor = Color.ForestGreen;
                    Flowproduktypanel.Enabled = true;
                }
                if (c == 0)
                {
                    MessageBox.Show("Liczba produktów wynosi 0! Nie można podzielić czasu bez produktu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    czasjednostki.Text = "";
                }
                if (c<0)
                {
                    MessageBox.Show("Liczba produktów wynosi "+c+" Nie można podzielić czasu skoro jest na minusie! Ktoś z pracowników usunął raport i nie odświeżył! Rozwiązanie = dodaj raport z brakująca liczbą produktów", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Flowproduktypanel.Enabled = true;
                //startpanel.BackColor = Color.DarkRed;
                // pracownik.ForeColor = Color.DarkRed;
                // stopstaticbtn.Visible = false;
                // Dodaj.Visible = false;
                
                
                przerwa = 0;
               
            };
            checkadder.Click += delegate
            {
                if(checkadder.CheckState == CheckState.Checked && checkstatic.CheckState == CheckState.Checked)// 1,1
                {
                    panelAder.Visible = true;
                    statyczny.Visible = true;
                    panelAder.Location = new Point(207, 6);

                    statyczny.Location = new Point(496, 6);
                    Flowprodukty.Location = new Point(809, 0);
                    produktaddtxt.Focus();



                }
                if (checkadder.CheckState == CheckState.Unchecked && checkstatic.CheckState == CheckState.Checked)//0,1
                {
                    //panelAder.Location = new Point();
                    panelAder.Visible = false;
                    statyczny.Visible = true;
                    statyczny.Location = new Point(207, 6);
                    Flowprodukty.Location = new Point(515, 0);
                }
                if (checkadder.CheckState == CheckState.Checked && checkstatic.CheckState == CheckState.Unchecked)//1,0
                {
                    panelAder.Visible = true;
                    statyczny.Visible = false;
                    panelAder.Location = new Point(207, 6);
                    //statyczny.Location = new Point(207, 6);
                    Flowprodukty.Location = new Point(496, 0);
                    produktaddtxt.Focus();

                }
                if (checkadder.CheckState == CheckState.Unchecked && checkstatic.CheckState == CheckState.Unchecked)//0,0
                {
                    panelAder.Visible = false;
                    statyczny.Visible = false;
                    //panelAder.Location = new Point();
                    //statyczny.Location = new Point();
                    Flowprodukty.Location = new Point(207, 0);
                }
            };
            checkstatic.Click += delegate
            {
                if (checkadder.CheckState == CheckState.Checked && checkstatic.CheckState == CheckState.Checked)// 1,1
                {
                    panelAder.Visible = true;
                    statyczny.Visible = true;
                    panelAder.Location = new Point(207, 6);

                    statyczny.Location = new Point(496, 6);
                    Flowprodukty.Location = new Point(809, 0);
                    produktaddtxt.Focus();
                }
                if (checkadder.CheckState == CheckState.Unchecked && checkstatic.CheckState == CheckState.Checked)//0,1
                {
                    //panelAder.Location = new Point();
                    panelAder.Visible = false;
                    statyczny.Visible = true;
                    statyczny.Location = new Point(207, 6);
                    Flowprodukty.Location = new Point(515, 0);
                }
                if (checkadder.CheckState == CheckState.Checked && checkstatic.CheckState == CheckState.Unchecked)//1,0
                {
                    panelAder.Visible = true;
                    statyczny.Visible = false;
                    panelAder.Location = new Point(207, 6);
                    //statyczny.Location = new Point(207, 6);
                    Flowprodukty.Location = new Point(496, 0);
                    produktaddtxt.Focus();
                }
                if (checkadder.CheckState == CheckState.Unchecked && checkstatic.CheckState == CheckState.Unchecked)//0,0
                {
                    panelAder.Visible = false;
                    statyczny.Visible = false;
                    //panelAder.Location = new Point();
                    //statyczny.Location = new Point();
                    Flowprodukty.Location = new Point(207, 0);
                }
            };
            X.Click += delegate
            {
                if (MessageBox.Show("Zakończyć prace pracownika " + pracownik.Text + "  ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flowLayoutPanel1.Controls.Remove(startpanel);
                }

            };
            Dodaj.Click += delegate
            {
                /*
                if(czydodaj == false)
                {
                    startpanel.Size = new Size(245, 205);
                }
                else
                {
                    startpanel.Size = new Size(245, 500);
                    Flowprodukty.Size = new Size(237, 160);
                }*/
                
                panelAder.Visible = true;
                panelAder.Size = new Size(237, 100);
                panelAder.BackColor = Color.White;
                idpracownikatxxt.Visible = true;
                PracoLab.Visible = true;
                ProduktlabADD.Visible = true;
                MOtlabADD.Visible = true;
                OperacjalabADD.Visible = true;
                IlosctlabADD.Visible = true;
                produktaddtxt.Visible = true;
                moaddtxt.Visible = true;
                operacjaaddtxt.Visible = true;
                piloscaddtxt.Visible = true;
                Add.Visible = true;
                
                //AddPanelProduktu.Visible = true;
                // produktaddtxt.Focus();
                //czasstart.Text = DateTime.Now.ToString();

                // statyczny.Adder(5); //  nie dziala
                // startpanel.Controls.Add(statyczny);// panelStatyczny.Add(); nie dziala
               // Flowproduktypanel.Enabled = false;
                idpracownikatxxt.Focus();
                
            };
           // moaddtxt.KeyPress += new KeyPressEventArgs(moaddtxt_KeyPress);
            idpracownikatxxt.KeyUp += new KeyEventHandler(idpracownika_KeyUp);
            produktaddtxt.KeyUp += new KeyEventHandler(produktaddtxt_KeyUp);
            moaddtxt.KeyUp += new KeyEventHandler(moaddtxt_KeyUp);
            operacjaaddtxt.KeyUp += new KeyEventHandler(operacjaaddtxt_KeyUp);
            // piloscaddtxt.Select();
            // piloscaddtxt.Select(0, piloscaddtxt.Value.ToString().Length); 
            piloscaddtxt.Enter += new EventHandler(pilosc_Enter);     
            piloscaddtxt.KeyUp += new KeyEventHandler(piloscaddtxt_KeyUp);
            
            
            //TextBox tb = new TextBox();
            // tb.KeyUp += new 


            Add.Click += delegate
            {
               // ID = dodajIDtxt.Text;
               /*
                if(idpracownikatxxt.Text != ID)
                {
                    MessageBox.Show("ID nie pasuje do pracownika!", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idpracownikatxxt.Focus();
                    return;
                }
                */

              /*  if (string.IsNullOrEmpty(produktaddtxt.Text))
                {
                    MessageBox.Show("Brak danych produktu!", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    produktaddtxt.Focus();
                    return;

                }*/
                
                if (string.IsNullOrEmpty(operacjaaddtxt.Text))
                {
                    MessageBox.Show("Brak operacji!", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacjaaddtxt.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(moaddtxt.Text))
                {
                    moaddtxt.Text = operacjaaddtxt.Text;
                    //MessageBox.Show("Brak numeru MO!", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // moaddtxt.Focus();
                    return;

                }
                if (operacjaaddtxt.Text == "PAK")
                {
                    moaddtxt.Text = "Pakowanie kitów";

                }

                /*  if (string.IsNullOrEmpty(piloscaddtxt.Text))
                  {
                      MessageBox.Show("Brak ilosci", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      piloscaddtxt.Focus();
                      return;

                  }
                  if (piloscaddtxt.Text == "0")
                  {
                      MessageBox.Show("Nie może być 0!", "Brak Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      piloscaddtxt.Focus();
                      return;

                  }*/

                int d;
                
                try
                {
                    d = int.Parse(piloscaddtxt.Text);

                    c += d;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
                
                    
                
                    suma.Text = c.ToString();
                    Produkt panelProduktu = new Produkt(produktaddtxt.Text, moaddtxt.Text, operacjaaddtxt.Text, piloscaddtxt.Text, pracownik.Text,c);
                    Flowproduktypanel.Controls.Add(panelProduktu.Panelproduktu(Flowproduktypanel, this, MoLabsave, pracownikLabsave, OperacjaLabsave, produktLabsave, CzasLabsave, StartLabsave, StopLabsave, pracownik, czasstart, czasstop));



                    idpracownikatxxt.Clear();
                    produktaddtxt.Focus();
                    produktaddtxt.Clear();
                    moaddtxt.Clear();
                    operacjaaddtxt.Clear();
                //piloscaddtxt.Controls.Clear();
                piloscaddtxt.Value = 1;
                produktaddtxt.Focus();
                if (czystart == false)
                {
                    startdata = DateTime.Now;
                    czasstart.Text = startdata.ToString();
                    czystart = true;
                }
                czydodaj = true;
                //c++;
                //suma.Text = c.ToString();

                //AddPanelProduktu.Visible = false;
                //startpanel.Size = new Size(251, 426);

               // panelAder.Size = new Size(237, 1);
                    produktaddtxt.Clear();
                    moaddtxt.Clear();
                    operacjaaddtxt.Clear();
               
                piloscaddtxt.Value = 1;
              
                    suma.Text = c.ToString();
                
                Flowprodukty.Focus();
               
               // startstaticbtn.Visible = false;

               // startpanel.BackColor = Color.DarkGreen;
               // pracownik.ForeColor = Color.DarkGreen;
                stopstaticbtn.Visible = true;
                statyczny.BackColor = Color.White;
                Flowproduktypanel.Enabled = false;
                checkstatic.Checked = true;
                checkadder.Checked = false;
                if (checkadder.CheckState == CheckState.Unchecked && checkstatic.CheckState == CheckState.Checked)//0,1
                {
                    //panelAder.Location = new Point();
                    panelAder.Visible = false;
                    statyczny.Visible = true;
                    statyczny.Location = new Point(207, 6);
                    Flowprodukty.Location = new Point(515, 0);
                }
                dodajIDtxt.Focus();

            };
            zakoncz.Click += delegate
             {
                 idpracownikatxxt.Clear();
                 produktaddtxt.Focus();
                 produktaddtxt.Clear();
                 moaddtxt.Clear();
                 operacjaaddtxt.Clear();
                //piloscaddtxt.Controls.Clear();
                piloscaddtxt.Value = 1;
                 produktaddtxt.Focus();
                
                 
                //c++;
                //suma.Text = c.ToString();

                //AddPanelProduktu.Visible = false;
                //startpanel.Size = new Size(251, 426);

                panelAder.Size = new Size(237, 1);
                 produktaddtxt.Clear();
                 moaddtxt.Clear();
                 operacjaaddtxt.Clear();    
                piloscaddtxt.Value = 1;


                 ProduktlabADD.Visible = false;
                 MOtlabADD.Visible = false;
                 OperacjalabADD.Visible = false;
                 IlosctlabADD.Visible = false;
                 produktaddtxt.Visible = false;
                 moaddtxt.Visible = false;
                 operacjaaddtxt.Visible = false;
                 piloscaddtxt.Visible = false;
                 Add.Visible = false;
                 PracoLab.Visible = false;
                 idpracownikatxxt.Visible = false;        
                 panelAder.Visible = false;
                 if (czydodaj == false)
                 {
                     startpanel.Size = new Size(245, 100);
                 }
                 else
                 {
                     startpanel.Size = new Size(245, 418);
                     Flowprodukty.Size = new Size(237, 183);
                 }
                 
             };
            //Usun.Click += delegate
            // {
            /*// AddPanelProduktu.Visible = false;
            startpanel.Size = new Size(251, 426);

            panelAder.Size = new Size(237, 1);
            produktaddtxt.Clear();
            moaddtxt.Clear();
            operacjaaddtxt.Clear();
            piloscaddtxt.Clear();
            panelAder.BackColor = Color.Red;
            ProduktlabADD.Visible = false;
            MOtlabADD.Visible = false;
            OperacjalabADD.Visible = false;
            IlosctlabADD.Visible = false;
            produktaddtxt.Visible = false;
            moaddtxt.Visible = false;
            operacjaaddtxt.Visible = false;
            piloscaddtxt.Visible = false;
            Add.Visible = false;
           // Produkt panelProduktu = new Produkt();
            //Flowproduktypanel.Controls.Remove(panelProduktu.Panelproduktu(Flowproduktypanel));
           // c--;
            suma.Text = c.ToString();

            */
            //  };

            


            #endregion
            return startpanel;
            
        }

       
        #endregion
        #region Metody textboxów dla Skanera oraz poprawnosc danych
        public void idpracownika_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.KeyValue == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }
        public void produktaddtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }
        public void moaddtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                
                SendKeys.Send("{TAB}");
            }

        }
       // public void moaddtxt_KeyPress(object sender, KeyPressEventArgs e)
      //  {
         //   char ch = e.KeyChar;
        //    if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&(e.KeyChar !='.'))
         //   {
          //      e.Handled = true;
         // }
       
        public void operacjaaddtxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                
            }
        }

        private void pilosc_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, 10);
        }
        public void piloscaddtxt_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyValue == (char)Keys.Return)
            {
                
                SendKeys.Send("{TAB}");
            }
           // NumericUpDown box = sender as NumericUpDown;
           // box.Select();

           // box.Select(0, box.Value.ToString().Length);
        }

        #endregion
        #region RemoveLiczbe - METODA
        public void RemoveLiczbe( string liczbaproduktu)
        {
            int conliczba = Int32.Parse(liczbaproduktu);
            liczbazwrotna = conliczba;

        }
        #endregion
        #region BazaAder - Metoda
        public void BazaAder(Panel panel,FlowLayoutPanel panel2,Label MoLab1, Label pracownik1, Label operacja1, Label produkt1, string czasik1, Label startlab1, Label stoplab1, string pracowniklab1, Label czasstart1, Label czasstop1)//Label workcenter,string sztuki, DateTime start,DateTime stop, string sumaczas, string idpracownika)
        {
          
            string imie = pracowniklab1;
            if (MessageBox.Show("Zakończyć projekt pracownika " +imie + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                

                try
                 {
                     this.moOperacjeTableAdapter.Fill(this.emosDataSet1.MoOperacje);
                     moOperacjeBindingSource.DataSource = this.emosDataSet1.MoOperacje;
                     moOperacjeTableAdapter.Update(this.emosDataSet1.MoOperacje);
                     this.emosDataSet1.MoOperacje.AddMoOperacjeRow(this.emosDataSet1.MoOperacje.NewMoOperacjeRow());
                     moOperacjeBindingSource.MoveLast();
                     MoLabsave.Text = MoLab1.Text;
                     OperacjaLabsave.Text = operacja1.Text;
                     pracownikLabsave.Text = imie;
                     produktLabsave.Text = produkt1.Text;
                     StartLabsave.Text = startlab1.Text;
                     StopLabsave.Text = stoplab1.Text;     
                      CzasLabsave.Text = czasik1;//sumaczas;
                      StartLabsave.Text = czasstart1.Text;
                      StopLabsave.Text = czasstop1.Text;         
                         moOperacjeBindingSource.EndEdit();
                     moOperacjeTableAdapter.Update(this.emosDataSet1.MoOperacje);
                     this.moOperacjeTableAdapter.Fill(this.emosDataSet1.MoOperacje);
                 }
                 catch (Exception e)
                 {
                     MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                panel2.Controls.Remove(panel);
                //dodajIDtxt.Focus();
            }

        }
        #endregion
        #region Button Form - METODY
        private void button1_Click(object sender, EventArgs e)
        {
           // String IMIE = "PAWEL";
            
            //BazaAder(IMIE);
            // CreateMyPanel();


        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            Close();
            Raport raport = new Raport();
            raport.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiderLogin login = new LiderLogin();
            login.Show();
        }

        private void dodajIDtxt_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Return)
           {
                //Glowny().Focus();
                Glowny();
                
            }
            //dodajIDtxt.Focus();
        }

        private void dodajProdtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                //dodajMOtxt.Focus();
            }
        }

        private void dodajMOtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                //dodajWCtxt.Focus();
            }
        }

        private void dodajWCtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                //button1.Focus();
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
           // dodajIDtxt.Focus();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                dodajIDtxt.Focus();

            }
        }
        #endregion

    }
}
