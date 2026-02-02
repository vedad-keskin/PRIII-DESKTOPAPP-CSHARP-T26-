using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB180079;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Izvjestaji;
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
    public partial class frmIznajmljivanjaIB180079 : Form
    {
        StudentServis studentServis = new StudentServis();
        KnjigeServis knjigeServis = new KnjigeServis();
        StudentiKnjigeServis studentiKnjigeServis = new StudentiKnjigeServis();
        public frmIznajmljivanjaIB180079()
        {
            InitializeComponent();
        }

        private void frmIznajmljivanjaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiKnjige.AutoGenerateColumns = false;

            UcitajStudentiKnjige();

            UcitajComboBox();
        }

        private void UcitajComboBox()
        {
            cbStudent.DataSource = studentServis.GetAll();

            cbKnjiga.DataSource = knjigeServis.GetAll();

            cbKnjiga.DisplayMember = "Naziv";

        }

        private void UcitajStudentiKnjige()
        {

            var studentiKnjige = studentiKnjigeServis.GetAllIncluded();


            if (studentiKnjige != null)
            {
                dgvStudentiKnjige.DataSource = null;
                dgvStudentiKnjige.DataSource = studentiKnjige;

            }


        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {

            var student = cbStudent.SelectedItem as Student;
            var knjiga = cbKnjiga.SelectedItem as KnjigeIB180079;


            if (studentiKnjigeServis.GetAll().Where(x => x.KnjigaId == knjiga.Id && x.Vracena == false).ToList().Count() >= knjiga.BrojPrimjeraka)
            {
                MessageBox.Show("Prekoračen iznajmljeni broj primjeraka", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (studentiKnjigeServis.GetAll().Exists(x =>
            x.StudentId == student.Id &&
            x.KnjigaId == knjiga.Id &&
            x.Vracena == false
            ))
            {

                MessageBox.Show("Student je već iznajmio odabranu knjigu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                var novaStudentKnjiga = new StudentiKnjigeIB180079()
                {

                    StudentId = student.Id,
                    KnjigaId = knjiga.Id,
                    DatumIznajmljivanja = DateTime.Now,
                    Vracena = false

                };

                studentiKnjigeServis.Add(novaStudentKnjiga);

                UcitajStudentiKnjige();


            }



        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {

            var odabraniStudent = cbStudent.SelectedItem as Student;

            await Task.Run(() => GenerisiIznajmljivanja(odabraniStudent));


        }

        private void GenerisiIznajmljivanja(Student? odabraniStudent)
        {

            var sveKnjige = knjigeServis.GetAll();

            var redniBroj = 0;

            var info = "";


            for (int i = 0; i < sveKnjige.Count(); i++)
            {

                if (!studentiKnjigeServis.GetAll().Exists(x =>
                x.StudentId == odabraniStudent.Id &&
                x.KnjigaId == sveKnjige[i].Id
                ))
                {

                    Thread.Sleep(300);

                    var novaStudentKnjiga = new StudentiKnjigeIB180079()
                    {

                        StudentId = odabraniStudent.Id,
                        KnjigaId = sveKnjige[i].Id,
                        DatumIznajmljivanja = DateTime.Now,
                        Vracena = false

                    };

                    studentiKnjigeServis.Add(novaStudentKnjiga);


                    redniBroj++;
                    info += $"{redniBroj}. {odabraniStudent} dodato zaduzenje {sveKnjige[i]}{Environment.NewLine}";


                }


            }


            Action action = () =>
            {

                txtInfo.Text = info;
                UcitajStudentiKnjige();
                MessageBox.Show($"Uspješno generisanje zaduženja", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            };
            BeginInvoke(action);


        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {

            var odabraniStudent = cbStudent.SelectedItem as Student;

            var frmIzvjestaj = new frmIzvjestaji(odabraniStudent);

            frmIzvjestaj.ShowDialog();

        }

        private void frmIznajmljivanjaIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
