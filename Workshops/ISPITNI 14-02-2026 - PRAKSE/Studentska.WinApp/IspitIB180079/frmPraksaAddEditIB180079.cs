using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB180079;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB180079
{
    public partial class frmPraksaAddEditIB180079 : Form
    {
        StudentPraksaServis studentPraksaServis = new StudentPraksaServis();
        StudentServis studentServis = new StudentServis();
        KompanijaServis kompanijaServis = new KompanijaServis();
        public frmPraksaAddEditIB180079()
        {
            InitializeComponent();
        }

        private void frmPraksaAddEditIB180079_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
        }

        private void UcitajComboBox()
        {
            cbStudent.DataSource = studentServis.GetAll();

            cbKompanija.DataSource = kompanijaServis.GetAll();

            cbStatus.SelectedIndex = 0;

            cbStatus.Enabled = false;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            var student = cbStudent.SelectedItem as Student;

            var kompanija = cbKompanija.SelectedItem as KompanijeIB180079;

            var datumPrijave = dtpDatumPrijave.Value;

            var status = cbStatus.SelectedItem.ToString();

            var novaPraksa = new StudentiPraksaIB180079()
            {
                StudentId = student.Id,
                KompanijaId = kompanija.Id,
                DatumPrijave = datumPrijave,
                Status = status

            };

            studentPraksaServis.Add(novaPraksa);

        }

        private void frmPraksaAddEditIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {

            var student = cbStudent.SelectedItem as Student;

            await Task.Run(() => GenerisiPrakse(student));

        }

        private void GenerisiPrakse(Student? student)
        {

            var sveKompanije = kompanijaServis.GetAll();

            var info = "";

            var redni = 1;

            for (int i = 0; i < sveKompanije.Count(); i++)
            {
                Thread.Sleep(300);

                var novaPraksa = new StudentiPraksaIB180079()
                {
                    StudentId = student.Id,
                    KompanijaId = sveKompanije[i].Id,
                    Status = "PODNESENA",
                    DatumPrijave = DateTime.Now,

                };

                info += $"{redni++} -> {novaPraksa.DatumPrijave.ToString("dd.MM.yyyy")} kreiran zahtjev za praksu {student} u kompaniji {sveKompanije[i]} {Environment.NewLine}";

                studentPraksaServis.Add(novaPraksa);

            }


            Action action = () =>
            {

                MessageBox.Show("Uspješno ste generisali prakse","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtInfo.Text = info;

            };
            BeginInvoke(action);



        }
    }
}
