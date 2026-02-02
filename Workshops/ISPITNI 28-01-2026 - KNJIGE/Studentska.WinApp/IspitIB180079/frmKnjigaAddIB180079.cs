using DocumentFormat.OpenXml;
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
    public partial class frmKnjigaAddIB180079 : Form
    {
        KnjigeServis knjigaServis = new KnjigeServis();
        private KnjigeIB180079 knjiga;

        public frmKnjigaAddIB180079()
        {
            InitializeComponent();
        }

        public frmKnjigaAddIB180079(KnjigeIB180079 knjiga)
        {
            InitializeComponent();
            this.knjiga = knjiga;
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pbSlika.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var slika = ImageHelper.ImageToByte(pbSlika.Image);

                var broj = int.Parse(txtBrojPrimjeraka.Text);

                var naziv = txtNaziv.Text;

                var autori = txtAutori.Text;


                if (broj <= 0)
                {
                    MessageBox.Show("Nije dovoljeno unijeti nulu niti negativan broj", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (knjigaServis.GetAll().Exists(x => 
                x.Naziv.ToLower() == naziv.ToLower() && 
                x.Autor.ToLower() == autori.ToLower()))
                {

                    MessageBox.Show("Nije dovoljeno unijeti knjigu sa istim nazivom i autorom", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (knjiga != null) // editovanje
                {

                    knjiga.Naziv = naziv;
                    knjiga.Autor = autori;
                    knjiga.BrojPrimjeraka = broj;
                    knjiga.Slika = slika;

                    knjigaServis.Update(knjiga);

                    DialogResult = DialogResult.OK;

                }
                else // dodavanje
                {

                    var novaKnjiga = new KnjigeIB180079()
                    {
                        Naziv = naziv,
                        Autor = autori,
                        BrojPrimjeraka = broj,
                        Slika = slika
                    };

                    knjigaServis.Add(novaKnjiga);

                    DialogResult = DialogResult.OK;


                }


            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidanUnos(pbSlika, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtNaziv, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtAutori, err, "Obavezan unos") &&
                Validator.ValidanUnos(txtBrojPrimjeraka, err, "Obavezan unos");
        }

        private void frmKnjigaAddIB180079_Load(object sender, EventArgs e)
        {
            UcitajInfo();
        }

        private void UcitajInfo()
        {
            if (knjiga != null)
            {

                pbSlika.Image = ImageHelper.ByteToImage(knjiga.Slika);
                txtNaziv.Text = knjiga.Naziv;
                txtAutori.Text = knjiga.Autor;
                txtBrojPrimjeraka.Text = knjiga.BrojPrimjeraka.ToString();
            
            }


        }
    }
}
