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
    public partial class frmPretragaIB180079 : Form
    {
        StudentiProjektiServis studentiProjektiServis = new StudentiProjektiServis();
        List<StudentiProjektiIB180079> studentiProjekti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudentiProjekte();
        }

        private void UcitajStudentiProjekte()
        {
            var pretraga = txtPretraga.Text.ToLower();

            var status = cmbStatus.SelectedItem as string;

            var stanje = cmbStanje.SelectedItem as string;

            studentiProjekti = studentiProjektiServis
                .GetAllIncluded()
                .Where(x => $"{x.Student.Ime} {x.Student.Prezime}".ToLower().Contains(pretraga) || x.Projekat.Naziv.ToLower().Contains(pretraga))
                .Where(x => status == "Sve" || x.Status == status)
                .Where(x => stanje == "Sve" || 
                (stanje == "Aktivna" && x.Arhivirana == false) ||
                (stanje == "Arhivirana" && x.Arhivirana == true))
                .ToList();



            if (studentiProjekti != null)
            {

                dgvStudentiProjekti.DataSource = null;
                dgvStudentiProjekti.DataSource = studentiProjekti;
            }

        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiProjekti.AutoGenerateColumns = false;

            cmbStatus.SelectedIndex = 0;
            cmbStanje.SelectedIndex = 0;

            UcitajStudentiProjekte();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudentiProjekte();
        }

        private void cmbStanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudentiProjekte();

        }

        private void dgvStudentiProjekti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                var odabranStudentProjekat = dgvStudentiProjekti.SelectedRows[0].DataBoundItem as StudentiProjektiIB180079;

                if (odabranStudentProjekat.Arhivirana == true)
                {
                    MessageBox.Show("Prijava je već arhivirana", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    odabranStudentProjekat.Arhivirana = true;

                    studentiProjektiServis.Update(odabranStudentProjekat);

                    UcitajStudentiProjekte();

                }


            }
        }

        private void btnNoviProjekat_Click(object sender, EventArgs e)
        {

            var frmAddProjekat = new frmProjekatAddIB180079();


            if (frmAddProjekat.ShowDialog() == DialogResult.OK)
            {

                UcitajStudentiProjekte();

            }
        }

        private void btnNovaPrijava_Click(object sender, EventArgs e)
        {

            var frmAddPrijava = new frmPrijavaAddEditIB180079();


            if (frmAddPrijava.ShowDialog() == DialogResult.OK)
            {

                UcitajStudentiProjekte();

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var frmIzvjestaj = new frmIzvjestaji(studentiProjekti);

            frmIzvjestaj.ShowDialog();
        }
    }
}
