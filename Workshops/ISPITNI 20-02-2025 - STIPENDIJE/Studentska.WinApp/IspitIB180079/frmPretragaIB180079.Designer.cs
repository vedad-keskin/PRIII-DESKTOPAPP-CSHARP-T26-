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
            cbGodina = new ComboBox();
            cbStipendijaGodina = new ComboBox();
            dgvStudentiStipendije = new DataGridView();
            SlikaInfo = new DataGridViewImageColumn();
            Student = new DataGridViewTextBoxColumn();
            AktivanInfo = new DataGridViewCheckBoxColumn();
            GodinaInfo = new DataGridViewTextBoxColumn();
            StipendijaInfo = new DataGridViewTextBoxColumn();
            IznosInfo = new DataGridViewTextBoxColumn();
            UkupnoInfo = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            chbAktivan = new CheckBox();
            label3 = new Label();
            cbSpol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Stipendija:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2026", "2025", "2024", "2023", "2022" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(241, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // cbStipendijaGodina
            // 
            cbStipendijaGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendijaGodina.FormattingEnabled = true;
            cbStipendijaGodina.Location = new Point(267, 32);
            cbStipendijaGodina.Name = "cbStipendijaGodina";
            cbStipendijaGodina.Size = new Size(241, 28);
            cbStipendijaGodina.TabIndex = 1;
            cbStipendijaGodina.SelectedIndexChanged += cbStipendijaGodina_SelectedIndexChanged;
            // 
            // dgvStudentiStipendije
            // 
            dgvStudentiStipendije.AllowUserToAddRows = false;
            dgvStudentiStipendije.AllowUserToDeleteRows = false;
            dgvStudentiStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiStipendije.Columns.AddRange(new DataGridViewColumn[] { SlikaInfo, Student, AktivanInfo, GodinaInfo, StipendijaInfo, IznosInfo, UkupnoInfo, Ukloni });
            dgvStudentiStipendije.Location = new Point(12, 66);
            dgvStudentiStipendije.Name = "dgvStudentiStipendije";
            dgvStudentiStipendije.ReadOnly = true;
            dgvStudentiStipendije.RowHeadersWidth = 51;
            dgvStudentiStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiStipendije.Size = new Size(1279, 363);
            dgvStudentiStipendije.TabIndex = 2;
            dgvStudentiStipendije.CellContentClick += dgvStudentiStipendije_CellContentClick;
            // 
            // SlikaInfo
            // 
            SlikaInfo.DataPropertyName = "SlikaInfo";
            SlikaInfo.HeaderText = "Slika";
            SlikaInfo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            SlikaInfo.MinimumWidth = 6;
            SlikaInfo.Name = "SlikaInfo";
            SlikaInfo.ReadOnly = true;
            SlikaInfo.Width = 50;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i prezime";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // AktivanInfo
            // 
            AktivanInfo.DataPropertyName = "AktivanInfo";
            AktivanInfo.HeaderText = "Aktivan";
            AktivanInfo.MinimumWidth = 6;
            AktivanInfo.Name = "AktivanInfo";
            AktivanInfo.ReadOnly = true;
            AktivanInfo.Width = 125;
            // 
            // GodinaInfo
            // 
            GodinaInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GodinaInfo.DataPropertyName = "GodinaInfo";
            GodinaInfo.HeaderText = "Godina";
            GodinaInfo.MinimumWidth = 6;
            GodinaInfo.Name = "GodinaInfo";
            GodinaInfo.ReadOnly = true;
            // 
            // StipendijaInfo
            // 
            StipendijaInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StipendijaInfo.DataPropertyName = "StipendijaInfo";
            StipendijaInfo.HeaderText = "Stipendija";
            StipendijaInfo.MinimumWidth = 6;
            StipendijaInfo.Name = "StipendijaInfo";
            StipendijaInfo.ReadOnly = true;
            // 
            // IznosInfo
            // 
            IznosInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IznosInfo.DataPropertyName = "IznosInfo";
            IznosInfo.HeaderText = "Mjesecni iznos";
            IznosInfo.MinimumWidth = 6;
            IznosInfo.Name = "IznosInfo";
            IznosInfo.ReadOnly = true;
            // 
            // UkupnoInfo
            // 
            UkupnoInfo.DataPropertyName = "UkupnoInfo";
            UkupnoInfo.HeaderText = "Ukupno";
            UkupnoInfo.MinimumWidth = 6;
            UkupnoInfo.Name = "UkupnoInfo";
            UkupnoInfo.ReadOnly = true;
            UkupnoInfo.Width = 125;
            // 
            // Ukloni
            // 
            Ukloni.HeaderText = "";
            Ukloni.MinimumWidth = 6;
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            Ukloni.Width = 125;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(514, 34);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 3;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Spol:";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(624, 34);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(241, 28);
            cbSpol.TabIndex = 5;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 437);
            Controls.Add(cbSpol);
            Controls.Add(label3);
            Controls.Add(chbAktivan);
            Controls.Add(dgvStudentiStipendije);
            Controls.Add(cbStipendijaGodina);
            Controls.Add(cbGodina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "Broj prikazanih stipendija: placeholder";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbGodina;
        private ComboBox cbStipendijaGodina;
        private DataGridView dgvStudentiStipendije;
        private DataGridViewImageColumn SlikaInfo;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewCheckBoxColumn AktivanInfo;
        private DataGridViewTextBoxColumn GodinaInfo;
        private DataGridViewTextBoxColumn StipendijaInfo;
        private DataGridViewTextBoxColumn IznosInfo;
        private DataGridViewTextBoxColumn UkupnoInfo;
        private DataGridViewButtonColumn Ukloni;
        private CheckBox chbAktivan;
        private Label label3;
        private ComboBox cbSpol;
    }
}