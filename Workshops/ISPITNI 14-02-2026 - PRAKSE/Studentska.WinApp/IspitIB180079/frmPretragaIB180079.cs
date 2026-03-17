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
    public partial class frmPretragaIB180079 : Form
    {
        StudentPraksaServis studentPraksaServis = new StudentPraksaServis();
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvPrakse.AutoGenerateColumns = false;

            cbStatus.SelectedIndex = 0;

            UcitajPrakse();
        }

        private void UcitajPrakse()
        {

            var status = cbStatus.SelectedItem.ToString();

            var pretraga = txtPretraga.Text.ToLower();

            var studentiPrakse = studentPraksaServis.GetAllIncluded()
                .Where(x => x.Status == status)
                .Where(x => x.Kompanija.Naziv.ToLower().Contains(pretraga)
                || $"{x.Student.Ime} {x.Student.Prezime}".ToLower().Contains(pretraga))
                .ToList();


            if (studentiPrakse != null)
            {

                dgvPrakse.DataSource = null;
                dgvPrakse.DataSource = studentiPrakse;

            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrakse();

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajPrakse();

        }

        private void dgvPrakse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu praksu ?", "Upit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    var odabranaPraksa = dgvPrakse.SelectedRows[0].DataBoundItem as StudentiPraksaIB180079;

                    studentPraksaServis.Remove(odabranaPraksa);

                    UcitajPrakse();

                }

            }
        }

        private void btnKompanija_Click(object sender, EventArgs e)
        {
            var frmKompanijaAdd = new frmKompanijaAddIB180079();

            if (frmKompanijaAdd.ShowDialog() == DialogResult.OK)
            {

                UcitajPrakse();

            }
        }

        private void btnPraksa_Click(object sender, EventArgs e)
        {
            var frmPraksaAdd = new frmPraksaAddEditIB180079();

            if (frmPraksaAdd.ShowDialog() == DialogResult.OK)
            {

                UcitajPrakse();

            }
        }
    }
}
