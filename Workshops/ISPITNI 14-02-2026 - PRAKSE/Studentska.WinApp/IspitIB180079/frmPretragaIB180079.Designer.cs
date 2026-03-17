namespace Studentska.WinApp.IspitIB180079
{
    partial class frmPretragaIB180079
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
            txtPretraga = new TextBox();
            cbStatus = new ComboBox();
            dgvPrakse = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Kompanija = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DatumPromjene = new DataGridViewTextBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            btnPraksa = new Button();
            btnKompanija = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrakse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime studenta ili naziv kompanije:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Status zahtjeva:";
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 32);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(401, 27);
            txtPretraga.TabIndex = 1;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "REALIZOVANA" });
            cbStatus.Location = new Point(427, 32);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(232, 28);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // dgvPrakse
            // 
            dgvPrakse.AllowUserToAddRows = false;
            dgvPrakse.AllowUserToDeleteRows = false;
            dgvPrakse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrakse.Columns.AddRange(new DataGridViewColumn[] { Student, Kompanija, Grad, Status, DatumPromjene, Obrisi });
            dgvPrakse.Location = new Point(12, 65);
            dgvPrakse.Name = "dgvPrakse";
            dgvPrakse.ReadOnly = true;
            dgvPrakse.RowHeadersWidth = 51;
            dgvPrakse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrakse.Size = new Size(1266, 364);
            dgvPrakse.TabIndex = 3;
            dgvPrakse.CellContentClick += dgvPrakse_CellContentClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Kompanija
            // 
            Kompanija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kompanija.DataPropertyName = "Kompanija";
            Kompanija.HeaderText = "Kompanija";
            Kompanija.MinimumWidth = 6;
            Kompanija.Name = "Kompanija";
            Kompanija.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "GradInfo";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DatumPromjene
            // 
            DatumPromjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPromjene.DataPropertyName = "DatumPromjene";
            DatumPromjene.HeaderText = "DatumPromjene";
            DatumPromjene.MinimumWidth = 6;
            DatumPromjene.Name = "DatumPromjene";
            DatumPromjene.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obrisi.HeaderText = "";
            Obrisi.MinimumWidth = 6;
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obriši";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // btnPraksa
            // 
            btnPraksa.Location = new Point(1126, 27);
            btnPraksa.Name = "btnPraksa";
            btnPraksa.Size = new Size(147, 29);
            btnPraksa.TabIndex = 4;
            btnPraksa.Text = "Nova praksa";
            btnPraksa.UseVisualStyleBackColor = true;
            btnPraksa.Click += btnPraksa_Click;
            // 
            // btnKompanija
            // 
            btnKompanija.Location = new Point(973, 29);
            btnKompanija.Name = "btnKompanija";
            btnKompanija.Size = new Size(147, 29);
            btnKompanija.TabIndex = 4;
            btnKompanija.Text = "Nova kompanija";
            btnKompanija.UseVisualStyleBackColor = true;
            btnKompanija.Click += btnKompanija_Click;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 435);
            Controls.Add(btnKompanija);
            Controls.Add(btnPraksa);
            Controls.Add(dgvPrakse);
            Controls.Add(cbStatus);
            Controls.Add(txtPretraga);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "Pretraga";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrakse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPretraga;
        private ComboBox cbStatus;
        private DataGridView dgvPrakse;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Kompanija;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DatumPromjene;
        private DataGridViewButtonColumn Obrisi;
        private Button btnPraksa;
        private Button btnKompanija;
    }
}