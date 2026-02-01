using DLWMS.Data.IspitIB180079;
using Studentska.Data.IspitIB180079;
using Studentska.Servis;
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
        StipendijeGodineServis stipendijeGodineServis = new StipendijeGodineServis();
        StudentiStipendijeServis studentiStipendijeServis = new StudentiStipendijeServis();

        SpolServis spolServis = new SpolServis();


        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiStipendije.AutoGenerateColumns = false;

            cbGodina.SelectedIndex = 0;


            //                  db.Spolovi.ToList();
            cbSpol.DataSource = spolServis.GetAll();


        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {

            var odabranaGodina = cbGodina?.SelectedItem?.ToString() ?? "";

            //var stipendijeGodine = stipendijeGodineServis.GetAllIncludedWithFilter(odabranaGodina);

            cbStipendijaGodina.DataSource = stipendijeGodineServis.GetAllIncluded()
                .Where(x => x.Godina == odabranaGodina)
                .ToList();


            //if (stipendijeGodine.Count() == 0)
            //{
            //    cbStipendijaGodina.DataSource = null;

            //    Text = "Broj prikazanih studenata: 0";

            //    MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {odabranaGodina} godini", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}



        }

        private void cbStipendijaGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudentStipendije();
        }

        private void UcitajStudentStipendije()
        {
            var odabranaStudentStipendija = cbStipendijaGodina.SelectedItem as StipendijeGodineIB180079;

            var aktivan = chbAktivan.Checked;


            var studentStipendije = studentiStipendijeServis.GetAllIncluded()
                .Where(x => x.StipendijaGodinaId == odabranaStudentStipendija.Id)
                .Where(x => x.Student.Aktivan == aktivan)
                .ToList();


            if (studentStipendije != null)
            {

                dgvStudentiStipendije.DataSource = null;
                dgvStudentiStipendije.DataSource = studentStipendije;

            }

            if (studentStipendije.Count() == 0)
            {

                MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {cbGodina.SelectedItem}. godini dodijeljena {odabranaStudentStipendija} stipendija", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void dgvStudentiStipendije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                if (MessageBox.Show("Da li ste sigurni da želite obrisati odabrani zapis ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    var odabanaStudentStipendija = dgvStudentiStipendije.SelectedRows[0].DataBoundItem as StudentiStipendijeIB180079;

                    studentiStipendijeServis.Remove(odabanaStudentStipendija);

                    UcitajStudentStipendije();

                }

            }
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudentStipendije();
        }
    }
}
