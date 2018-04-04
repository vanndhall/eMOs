namespace eMOs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.Open_Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mOopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopidPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopproduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopNumerMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopidZleceniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopdataStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopdataKoniecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopczasTrwaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopEdycjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOopDataEdycjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moOperacjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emosDataSet1 = new eMOs.emosDataSet1();
            this.StopLabsave = new System.Windows.Forms.Label();
            this.CzasLabsave = new System.Windows.Forms.Label();
            this.StartLabsave = new System.Windows.Forms.Label();
            this.produktLabsave = new System.Windows.Forms.Label();
            this.MoLabsave = new System.Windows.Forms.Label();
            this.pracownikLabsave = new System.Windows.Forms.Label();
            this.OperacjaLabsave = new System.Windows.Forms.Label();
            this.moOperacjeTableAdapter = new eMOs.emosDataSet1TableAdapters.MoOperacjeTableAdapter();
            this.dodajIDtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moOperacjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(702, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 10);
            this.button2.TabIndex = 17;
            this.button2.Text = "LiderTool";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Open_Button
            // 
            this.Open_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Open_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Open_Button.Location = new System.Drawing.Point(804, 6);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(79, 13);
            this.Open_Button.TabIndex = 16;
            this.Open_Button.Text = "Raporty";
            this.Open_Button.UseVisualStyleBackColor = false;
            this.Open_Button.Visible = false;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(959, 251);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.StopLabsave);
            this.panel2.Controls.Add(this.CzasLabsave);
            this.panel2.Controls.Add(this.StartLabsave);
            this.panel2.Controls.Add(this.produktLabsave);
            this.panel2.Controls.Add(this.MoLabsave);
            this.panel2.Controls.Add(this.pracownikLabsave);
            this.panel2.Controls.Add(this.OperacjaLabsave);
            this.panel2.Location = new System.Drawing.Point(9, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 90);
            this.panel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mOopidDataGridViewTextBoxColumn,
            this.mOopidPracownikaDataGridViewTextBoxColumn,
            this.mOopproduktDataGridViewTextBoxColumn,
            this.mOopNumerMODataGridViewTextBoxColumn,
            this.mOopidZleceniaDataGridViewTextBoxColumn,
            this.mOopdataStartDataGridViewTextBoxColumn,
            this.mOopdataKoniecDataGridViewTextBoxColumn,
            this.mOopczasTrwaniaDataGridViewTextBoxColumn,
            this.mOopEdycjaDataGridViewTextBoxColumn,
            this.mOopDataEdycjiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moOperacjeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(959, 90);
            this.dataGridView1.TabIndex = 1;
            // 
            // mOopidDataGridViewTextBoxColumn
            // 
            this.mOopidDataGridViewTextBoxColumn.DataPropertyName = "MOop_id";
            this.mOopidDataGridViewTextBoxColumn.HeaderText = "MOop_id";
            this.mOopidDataGridViewTextBoxColumn.Name = "mOopidDataGridViewTextBoxColumn";
            this.mOopidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopidPracownikaDataGridViewTextBoxColumn
            // 
            this.mOopidPracownikaDataGridViewTextBoxColumn.DataPropertyName = "MOop_idPracownika";
            this.mOopidPracownikaDataGridViewTextBoxColumn.HeaderText = "MOop_idPracownika";
            this.mOopidPracownikaDataGridViewTextBoxColumn.Name = "mOopidPracownikaDataGridViewTextBoxColumn";
            this.mOopidPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopproduktDataGridViewTextBoxColumn
            // 
            this.mOopproduktDataGridViewTextBoxColumn.DataPropertyName = "MOop_produkt";
            this.mOopproduktDataGridViewTextBoxColumn.HeaderText = "MOop_produkt";
            this.mOopproduktDataGridViewTextBoxColumn.Name = "mOopproduktDataGridViewTextBoxColumn";
            this.mOopproduktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopNumerMODataGridViewTextBoxColumn
            // 
            this.mOopNumerMODataGridViewTextBoxColumn.DataPropertyName = "MOop_NumerMO";
            this.mOopNumerMODataGridViewTextBoxColumn.HeaderText = "MOop_NumerMO";
            this.mOopNumerMODataGridViewTextBoxColumn.Name = "mOopNumerMODataGridViewTextBoxColumn";
            this.mOopNumerMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopidZleceniaDataGridViewTextBoxColumn
            // 
            this.mOopidZleceniaDataGridViewTextBoxColumn.DataPropertyName = "MOop_idZlecenia";
            this.mOopidZleceniaDataGridViewTextBoxColumn.HeaderText = "MOop_idZlecenia";
            this.mOopidZleceniaDataGridViewTextBoxColumn.Name = "mOopidZleceniaDataGridViewTextBoxColumn";
            this.mOopidZleceniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopdataStartDataGridViewTextBoxColumn
            // 
            this.mOopdataStartDataGridViewTextBoxColumn.DataPropertyName = "MOop_dataStart";
            this.mOopdataStartDataGridViewTextBoxColumn.HeaderText = "MOop_dataStart";
            this.mOopdataStartDataGridViewTextBoxColumn.Name = "mOopdataStartDataGridViewTextBoxColumn";
            this.mOopdataStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopdataKoniecDataGridViewTextBoxColumn
            // 
            this.mOopdataKoniecDataGridViewTextBoxColumn.DataPropertyName = "MOop_dataKoniec";
            this.mOopdataKoniecDataGridViewTextBoxColumn.HeaderText = "MOop_dataKoniec";
            this.mOopdataKoniecDataGridViewTextBoxColumn.Name = "mOopdataKoniecDataGridViewTextBoxColumn";
            this.mOopdataKoniecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopczasTrwaniaDataGridViewTextBoxColumn
            // 
            this.mOopczasTrwaniaDataGridViewTextBoxColumn.DataPropertyName = "MOop_czasTrwania";
            this.mOopczasTrwaniaDataGridViewTextBoxColumn.HeaderText = "MOop_czasTrwania";
            this.mOopczasTrwaniaDataGridViewTextBoxColumn.Name = "mOopczasTrwaniaDataGridViewTextBoxColumn";
            this.mOopczasTrwaniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopEdycjaDataGridViewTextBoxColumn
            // 
            this.mOopEdycjaDataGridViewTextBoxColumn.DataPropertyName = "MOop_Edycja";
            this.mOopEdycjaDataGridViewTextBoxColumn.HeaderText = "MOop_Edycja";
            this.mOopEdycjaDataGridViewTextBoxColumn.Name = "mOopEdycjaDataGridViewTextBoxColumn";
            this.mOopEdycjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOopDataEdycjiDataGridViewTextBoxColumn
            // 
            this.mOopDataEdycjiDataGridViewTextBoxColumn.DataPropertyName = "MOop_Data_Edycji";
            this.mOopDataEdycjiDataGridViewTextBoxColumn.HeaderText = "MOop_Data_Edycji";
            this.mOopDataEdycjiDataGridViewTextBoxColumn.Name = "mOopDataEdycjiDataGridViewTextBoxColumn";
            this.mOopDataEdycjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moOperacjeBindingSource
            // 
            this.moOperacjeBindingSource.DataMember = "MoOperacje";
            this.moOperacjeBindingSource.DataSource = this.emosDataSet1;
            // 
            // emosDataSet1
            // 
            this.emosDataSet1.DataSetName = "emosDataSet1";
            this.emosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StopLabsave
            // 
            this.StopLabsave.AutoSize = true;
            this.StopLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_dataKoniec", true));
            this.StopLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StopLabsave.Location = new System.Drawing.Point(97, 37);
            this.StopLabsave.Name = "StopLabsave";
            this.StopLabsave.Size = new System.Drawing.Size(31, 13);
            this.StopLabsave.TabIndex = 12;
            this.StopLabsave.Text = "   .    ";
            // 
            // CzasLabsave
            // 
            this.CzasLabsave.AutoSize = true;
            this.CzasLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_czasTrwania", true));
            this.CzasLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CzasLabsave.Location = new System.Drawing.Point(50, 37);
            this.CzasLabsave.Name = "CzasLabsave";
            this.CzasLabsave.Size = new System.Drawing.Size(25, 13);
            this.CzasLabsave.TabIndex = 13;
            this.CzasLabsave.Text = "123";
            // 
            // StartLabsave
            // 
            this.StartLabsave.AutoSize = true;
            this.StartLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_dataStart", true));
            this.StartLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartLabsave.Location = new System.Drawing.Point(104, 13);
            this.StartLabsave.Name = "StartLabsave";
            this.StartLabsave.Size = new System.Drawing.Size(28, 13);
            this.StartLabsave.TabIndex = 11;
            this.StartLabsave.Text = " .     ";
            // 
            // produktLabsave
            // 
            this.produktLabsave.AutoSize = true;
            this.produktLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_produkt", true));
            this.produktLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.produktLabsave.Location = new System.Drawing.Point(50, 14);
            this.produktLabsave.Name = "produktLabsave";
            this.produktLabsave.Size = new System.Drawing.Size(25, 13);
            this.produktLabsave.TabIndex = 8;
            this.produktLabsave.Text = "123";
            // 
            // MoLabsave
            // 
            this.MoLabsave.AutoSize = true;
            this.MoLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_NumerMO", true));
            this.MoLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MoLabsave.Location = new System.Drawing.Point(4, 37);
            this.MoLabsave.Name = "MoLabsave";
            this.MoLabsave.Size = new System.Drawing.Size(25, 13);
            this.MoLabsave.TabIndex = 9;
            this.MoLabsave.Text = "123";
            // 
            // pracownikLabsave
            // 
            this.pracownikLabsave.AutoSize = true;
            this.pracownikLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_idPracownika", true));
            this.pracownikLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pracownikLabsave.Location = new System.Drawing.Point(4, 13);
            this.pracownikLabsave.Name = "pracownikLabsave";
            this.pracownikLabsave.Size = new System.Drawing.Size(28, 13);
            this.pracownikLabsave.TabIndex = 7;
            this.pracownikLabsave.Text = "123 ";
            // 
            // OperacjaLabsave
            // 
            this.OperacjaLabsave.AutoSize = true;
            this.OperacjaLabsave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moOperacjeBindingSource, "MOop_idZlecenia", true));
            this.OperacjaLabsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OperacjaLabsave.Location = new System.Drawing.Point(3, 61);
            this.OperacjaLabsave.Name = "OperacjaLabsave";
            this.OperacjaLabsave.Size = new System.Drawing.Size(25, 13);
            this.OperacjaLabsave.TabIndex = 10;
            this.OperacjaLabsave.Text = "123";
            // 
            // moOperacjeTableAdapter
            // 
            this.moOperacjeTableAdapter.ClearBeforeFill = true;
            // 
            // dodajIDtxt
            // 
            this.dodajIDtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajIDtxt.Location = new System.Drawing.Point(9, 25);
            this.dodajIDtxt.Name = "dodajIDtxt";
            this.dodajIDtxt.PasswordChar = '*';
            this.dodajIDtxt.Size = new System.Drawing.Size(959, 20);
            this.dodajIDtxt.TabIndex = 0;
            this.dodajIDtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dodajIDtxt_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Zeskanuj ID aby rozpocząć projekt:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(360, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dodajIDtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eMOs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moOperacjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CzasLabsave;
        private System.Windows.Forms.Label StopLabsave;
        private System.Windows.Forms.Label StartLabsave;
        private System.Windows.Forms.Label OperacjaLabsave;
        private System.Windows.Forms.Label MoLabsave;
        private System.Windows.Forms.Label produktLabsave;
        private System.Windows.Forms.Label pracownikLabsave;
        private emosDataSet1 emosDataSet1;
        private System.Windows.Forms.BindingSource moOperacjeBindingSource;
        private emosDataSet1TableAdapters.MoOperacjeTableAdapter moOperacjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopidPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopproduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopNumerMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopidZleceniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopdataStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopdataKoniecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopczasTrwaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopEdycjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOopDataEdycjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dodajIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

