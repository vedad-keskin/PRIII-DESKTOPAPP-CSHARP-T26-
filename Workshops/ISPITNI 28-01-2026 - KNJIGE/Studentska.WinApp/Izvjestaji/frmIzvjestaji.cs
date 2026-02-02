using Microsoft.Reporting.WinForms;
using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student? odabraniStudent;
        StudentiKnjigeServis studentiKnjigeServis = new StudentiKnjigeServis();

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(Student? odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            UcitajIzvjestaj();

            reportViewer1.RefreshReport();
        }

        private void UcitajIzvjestaj()
        {
            
            var iznajmljivanjaStudenta = studentiKnjigeServis
                .GetAllIncluded()
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();


            var tblIznajmljivanja = new dsIzvjestaji.dsStudentiKnjigeDataTable();

            var sumaDana = 0;

            for (int i = 0; i < iznajmljivanjaStudenta.Count(); i++)
            {
                var Red = tblIznajmljivanja.NewdsStudentiKnjigeRow();

                Red.Rb = (i + 1).ToString();
                Red.Knjiga = iznajmljivanjaStudenta[i].Knjiga.ToString();
                Red.Vracena = iznajmljivanjaStudenta[i].Vracena == true ? "Da" : "Ne";


                DateTime datumKraja = iznajmljivanjaStudenta[i].DatumVracanja ?? DateTime.Now;

                int brojDana = (datumKraja - iznajmljivanjaStudenta[i].DatumIznajmljivanja).Days + 1;

                Red.Broj = brojDana.ToString();

                sumaDana += brojDana;

                tblIznajmljivanja.Rows.Add(Red);

            }

            var rds = new ReportDataSource();

            rds.Value = tblIznajmljivanja;
            rds.Name = "dsStudentiKnjige";

            reportViewer1.LocalReport.DataSources.Add(rds); 

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("student",odabraniStudent.ToString()));
            rpc.Add(new ReportParameter("brojDana",sumaDana.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);

        }
    }
}
