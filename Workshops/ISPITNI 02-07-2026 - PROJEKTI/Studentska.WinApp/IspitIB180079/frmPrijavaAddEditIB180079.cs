using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB180079;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB180079
{
    public partial class frmPrijavaAddEditIB180079 : Form
    {
        StudentiProjektiServis studentiProjektiServis = new StudentiProjektiServis();
        StudentServis studentServis = new StudentServis();
        ProjektiServis projektiServis = new ProjektiServis();
        public frmPrijavaAddEditIB180079()
        {
            InitializeComponent();
        }

        private void frmPrijavaAddEditIB180079_Load(object sender, EventArgs e)
        {

            UcitajInfo();


        }

        private void UcitajInfo()
        {
            cmbStatus.SelectedIndex = 0;

            cmbStatus.Enabled = false;

            cmbStudent.DataSource = studentServis.GetAll();

            cmbProjekat.DataSource = projektiServis.GetAll()
                .Where(x => x.Aktivan == true)
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var student = cmbStudent.SelectedItem as Student;

                var projekat = cmbProjekat.SelectedItem as ProjektiIB180079;

                var datumPrijave = dtpDatumPrijave.Value;

                var status = cmbStatus.SelectedItem as string;


                if (datumPrijave > projekat.RokZavrsetka)
                {
                    MessageBox.Show("Datum prijave ne može biti veće od roka završetka projekta", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (studentiProjektiServis.GetAll()
                    .Exists(x => x.StudentId == student.Id
                    && x.ProjekatId == projekat.Id
                    && x.Arhivirana == false))
                {

                    MessageBox.Show($"Student {student} već ima aktivnu prijavu na projekat {projekat}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (studentiProjektiServis.GetAll()
                    .Exists(x => x.StudentId == student.Id && x.Status == "PRIHVACENA"))
                {

                    MessageBox.Show($"Student {student} već ima prihvaćenu prijavu i ne može slati nove dok prethodna ne bude završena", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {


                    var noviStudentProjekat = new StudentiProjektiIB180079()
                    {

                        StudentId = student.Id,
                        ProjekatId = projekat.Id,
                        DatumPrijave = datumPrijave,
                        Status = status,
                        //DatumPromjene = DateTime.Now, // moze se ovako pa da se ne stavlja datum promjene na nullable a moze se i staviti pa da se ovo pohranjuje tek kod edita
                        Arhivirana = false

                    };

                    studentiProjektiServis.Add(noviStudentProjekat);

                    DialogResult = DialogResult.OK;

                }




            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidanUnos(cmbProjekat, err, "Obavezno polje") &&
                Validator.ValidanUnos(cmbStudent, err, "Obavezno polje");
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {

            var student = cmbStudent.SelectedItem as Student;

            await Task.Run(() => GenerisiPrijave(student));

        }

        private void GenerisiPrijave(Student? student)
        {


            var aktivniProjekti = projektiServis.GetAll()
                .Where(x => x.Aktivan == true && x.RokZavrsetka > DateTime.Now)
                .ToList();

            var info = "";

            for (int i = 0; i < aktivniProjekti.Count(); i++)
            {

                if (!(studentiProjektiServis.GetAll().Exists(x => x.ProjekatId == aktivniProjekti[i].Id && x.StudentId == student.Id && x.Arhivirana == false)))
                {

                    Thread.Sleep(300);

                    var noviStudentProjekat = new StudentiProjektiIB180079()
                    {
                        StudentId = student.Id,
                        ProjekatId = aktivniProjekti[i].Id,
                        DatumPrijave = DateTime.Now,
                        Arhivirana = false,
                        Status = "PODNESENA",
                        DatumPromjene = DateTime.Now

                    };

                    info += $"Dodata prijava na projekat '{aktivniProjekti[i]}' - studentu {student}.{Environment.NewLine}";

                    studentiProjektiServis.Add(noviStudentProjekat);

                }


            }




            Action action = () =>
            {

                if (info == "")
                {
                    MessageBox.Show($"Generisanje za studenta {student} nije izvršeno jer ne zadvoljava zahtjeve generisanja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Generisanje uspješno završeno za studenta {student}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtInfo.Text = info;

                }

            };
            BeginInvoke(action);



        }

        private void frmPrijavaAddEditIB180079_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
