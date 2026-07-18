namespace Studentska.WinApp.IspitIB180079
{
    partial class frmPrijavaAddEditIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbStudent = new ComboBox();
            cmbProjekat = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            cmbStatus = new ComboBox();
            button1 = new Button();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnGenerisi = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
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
            label2.Location = new Point(400, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Projekat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 0;
            label3.Text = "Datum prijave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 72);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 0;
            label4.Text = "Status prijave:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 32);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(361, 28);
            cmbStudent.TabIndex = 1;
            // 
            // cmbProjekat
            // 
            cmbProjekat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjekat.FormattingEnabled = true;
            cmbProjekat.Location = new Point(400, 32);
            cmbProjekat.Name = "cmbProjekat";
            cmbProjekat.Size = new Size(361, 28);
            cmbProjekat.TabIndex = 1;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(12, 95);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(361, 27);
            dtpDatumPrijave.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(400, 97);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(361, 28);
            cmbStatus.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(613, 148);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 3;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(23, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 277);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(726, 245);
            txtInfo.TabIndex = 0;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(29, 148);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(143, 29);
            btnGenerisi.TabIndex = 5;
            btnGenerisi.Text = "Generiši prijave";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // frmPrijavaAddEditIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 485);
            Controls.Add(btnGenerisi);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbProjekat);
            Controls.Add(cmbStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPrijavaAddEditIB180079";
            Text = "Nova prijava na projekat";
            FormClosing += frmPrijavaAddEditIB180079_FormClosing;
            Load += frmPrijavaAddEditIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
        private ComboBox cmbStudent;
        private ComboBox cmbProjekat;
        private DateTimePicker dtpDatumPrijave;
        private ComboBox cmbStatus;
        private Button button1;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnGenerisi;
    }
}