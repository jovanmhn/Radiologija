using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiologija
{
    public partial class FormStampa : DevExpress.XtraEditors.XtraForm
    {
        XtraReport1 report { get; set; }

        public FormStampa(nalaz nalaz, string hospital, string modalitet, string operater, string doktor)
        {
            InitializeComponent();
            report = new XtraReport1();
            
            report.Parameters["nalaz"].Value = nalaz.nalaz_tekst;
            report.Parameters["datum_pregled"].Value = nalaz.datum_pregleda.ToString("dd.MM.yyyy, HH:mm");
            report.Parameters["Datum_rodj"].Value = (nalaz.datum_rodj != null) ? nalaz.datum_rodj.Value.ToString("dd.MM.yyyy") : "";
            report.Parameters["hospital"].Value = hospital;
            report.Parameters["Ime"].Value = nalaz.ime;
            report.Parameters["Prezime"].Value = nalaz.prezime;
            report.Parameters["Modalitet"].Value = modalitet;
            report.Parameters["operater"].Value = operater;
            report.Parameters["doktor"].Value = doktor;
            report.Parameters["napomena"].Value = nalaz.napomena;
            if (String.IsNullOrWhiteSpace(nalaz.napomena))
            {
                report.Napomena_label.Visible = false;
                report.Napomena_label2.Visible = false;
            }
            report.CreateDocument();
            
            
            documentViewer1.DocumentSource = report;

            documentViewer1.Refresh();
            
        }
        public FormStampa(nalaz nalaz)
        {
            InitializeComponent();
            report = new XtraReport1();

            report.Parameters["nalaz"].Value = nalaz.nalaz_tekst;
            report.Parameters["datum_pregled"].Value = nalaz.datum_pregleda.ToString("dd.MM.yyyy, HH:mm");
            report.Parameters["Datum_rodj"].Value = (nalaz.datum_rodj != null) ? nalaz.datum_rodj.Value.ToString("dd.MM.yyyy") : "";
            report.Parameters["hospital"].Value = nalaz.hospital.naziv;
            report.Parameters["Ime"].Value = nalaz.ime;
            report.Parameters["Prezime"].Value = nalaz.prezime;
            report.Parameters["Modalitet"].Value = nalaz.modalitet.naziv;
            report.Parameters["operater"].Value = (nalaz.operater != null) ? nalaz.operater.info_naziv : "";
            report.Parameters["doktor"].Value = (nalaz.doktor!= null) ? nalaz.doktor.info_naziv : "";
            report.Parameters["napomena"].Value = nalaz.napomena;
            if (String.IsNullOrWhiteSpace(nalaz.napomena))
            {
                report.Napomena_label.Visible = false;
                report.Napomena_label2.Visible = false;
            }
            report.CreateDocument();

            documentViewer1.DocumentSource = report;

            documentViewer1.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ReportPrintTool printtool = new ReportPrintTool(report);
            
            printtool.PrintDialog();
        }
    }
}
