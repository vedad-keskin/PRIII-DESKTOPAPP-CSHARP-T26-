namespace Studentska.WinApp.IspitIB180079
{
    partial class frmKompanijaAddIB180079
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
            components = new System.ComponentModel.Container();
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chbAktivna = new CheckBox();
            txtNaziv = new TextBox();
            txtAdresa = new TextBox();
            txtMax = new TextBox();
            txtURL = new TextBox();
            cbGrad = new ComboBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ofd = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(228, 221);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 135);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 1;
            label3.Text = "Maksimalno studenata:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 12);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "Grad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 73);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 1;
            label5.Text = "URL:";
            // 
            // chbAktivna
            // 
            chbAktivna.AutoSize = true;
            chbAktivna.Checked = true;
            chbAktivna.CheckState = CheckState.Checked;
            chbAktivna.Location = new Point(605, 154);
            chbAktivna.Name = "chbAktivna";
            chbAktivna.Size = new Size(80, 24);
            chbAktivna.TabIndex = 2;
            chbAktivna.Text = "Aktivna";
            chbAktivna.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(264, 35);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(313, 27);
            txtNaziv.TabIndex = 3;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(264, 97);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(313, 27);
            txtAdresa.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(264, 158);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(313, 27);
            txtMax.TabIndex = 3;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(605, 96);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(313, 27);
            txtURL.TabIndex = 3;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(605, 34);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(313, 28);
            cbGrad.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(776, 215);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(142, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // frmKompanijaAddIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 255);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbGrad);
            Controls.Add(txtMax);
            Controls.Add(txtAdresa);
            Controls.Add(txtURL);
            Controls.Add(txtNaziv);
            Controls.Add(chbAktivna);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Name = "frmKompanijaAddIB180079";
            Text = "Kompanija";
            Load += frmKompanijaAddIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chbAktivna;
        private TextBox txtNaziv;
        private TextBox txtAdresa;
        private TextBox txtMax;
        private TextBox txtURL;
        private ComboBox cbGrad;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog ofd;
    }
}