using Microsoft.Reporting.WinForms;
using Studentska.Data.IspitIB180079;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiProjektiIB180079> studentiProjekti;

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(List<StudentiProjektiIB180079> studentiProjekti)
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
            this.studentiProjekti = studentiProjekti;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            UcitajReport();

            reportViewer1.RefreshReport();
        }

        private void UcitajReport()
        {

            var tblStudentiProjekti = new dsIzvjestaji.dsStudentiProjektiDataTable();

            var suma = 0;

            for (int i = 0; i < studentiProjekti.Count(); i++)
            {

                var noviRed = tblStudentiProjekti.NewdsStudentiProjektiRow();

                noviRed.Rb = (i + 1).ToString();
                noviRed.Student = studentiProjekti[i].Student.ToString();
                noviRed.Projekat = studentiProjekti[i].Projekat.ToString();
                noviRed.Stanje = studentiProjekti[i].Stanje;
                noviRed.RokZavrsetka = studentiProjekti[i].RokZavrsetkaInfo.ToString("dd.MM.yyyy");

                var broj = studentiProjekti[i].RokZavrsetkaInfo < DateTime.Now ? 0 : (studentiProjekti[i].RokZavrsetkaInfo - DateTime.Now).Days;

                noviRed.BrojDana = broj.ToString();
                suma += broj;

                tblStudentiProjekti.Rows.Add(noviRed);

            }

            var rpc = new ReportParameterCollection();

            float prosjek = suma / studentiProjekti.Count();

            rpc.Add(new ReportParameter("prosjek", prosjek.ToString("0.00")));

            reportViewer1.LocalReport.SetParameters(rpc);

            var rds = new ReportDataSource();

            rds.Name = "dsStudentiProjekti";
            rds.Value = tblStudentiProjekti;

            reportViewer1.LocalReport.DataSources.Add(rds);

        }
    }
}
