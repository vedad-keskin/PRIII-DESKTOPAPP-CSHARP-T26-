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
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB180079
{
    public partial class frmKompanijaAddIB180079 : Form
    {
        KompanijaServis kompanijaServis = new KompanijaServis();
        GradServis gradServis = new GradServis();
        public frmKompanijaAddIB180079()
        {
            InitializeComponent();
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pbLogo.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var logo =  ImageHelper.ImageToByte(pbLogo.Image);

                var grad = cbGrad.SelectedItem as Grad;

                var max = int.Parse(txtMax.Text);
                
                var aktivna = chbAktivna.Checked;
                
                var naziv = txtNaziv.Text;
                var adresa = txtAdresa.Text;
                var url = txtURL.Text;

                var novaKompanija = new KompanijeIB180079
                {
                    Logo = logo,
                    GradId = grad.Id,
                    Max = max,
                    Aktivna = aktivna,
                    Naziv = naziv,
                    Adresa = adresa,
                    Url = url
                };

                kompanijaServis.Add(novaKompanija);

                DialogResult = DialogResult.OK;


            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidanUnos(txtNaziv, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtAdresa, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtMax, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtURL, err, "Obavezan unos") &&
                Validator.ValidanUnos(pbLogo, err, "Obavezan unos");

        }

        private void frmKompanijaAddIB180079_Load(object sender, EventArgs e)
        {
            cbGrad.DataSource = gradServis.GetAll();
        }

      
    }
}
