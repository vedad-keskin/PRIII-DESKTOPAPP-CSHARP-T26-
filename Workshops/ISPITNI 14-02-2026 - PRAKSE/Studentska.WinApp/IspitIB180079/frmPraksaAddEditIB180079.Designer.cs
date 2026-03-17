namespace Studentska.WinApp.IspitIB180079
{
    partial class frmPraksaAddEditIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbStudent = new ComboBox();
            cbKompanija = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            cbStatus = new ComboBox();
            btnSacuvaj = new Button();
            groupBox1 = new GroupBox();
            btnGenerisi = new Button();
            txtInfo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Kompanija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 71);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 71);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 0;
            label4.Text = "Datum prijave:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(12, 32);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(443, 28);
            cbStudent.TabIndex = 1;
            // 
            // cbKompanija
            // 
            cbKompanija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKompanija.FormattingEnabled = true;
            cbKompanija.Location = new Point(464, 32);
            cbKompanija.Name = "cbKompanija";
            cbKompanija.Size = new Size(443, 28);
            cbKompanija.TabIndex = 1;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(12, 101);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(443, 27);
            dtpDatumPrijave.TabIndex = 2;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "REALIZOVANA" });
            cbStatus.Location = new Point(464, 100);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(443, 28);
            cbStatus.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(753, 150);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(154, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(12, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 267);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator Info";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 26);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(883, 29);
            btnGenerisi.TabIndex = 0;
            btnGenerisi.Text = "Generiši zahtjeve";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(12, 61);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(883, 200);
            txtInfo.TabIndex = 1;
            // 
            // frmPraksaAddEditIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 475);
            Controls.Add(groupBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cbStatus);
            Controls.Add(cbKompanija);
            Controls.Add(cbStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPraksaAddEditIB180079";
            Text = "Praksa";
            FormClosed += frmPraksaAddEditIB180079_FormClosed;
            Load += frmPraksaAddEditIB180079_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbStudent;
        private ComboBox cbKompanija;
        private DateTimePicker dtpDatumPrijave;
        private ComboBox cbStatus;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnGenerisi;
    }
}