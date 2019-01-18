using DevExpress.XtraEditors;
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
    public partial class FormListaSablona : Form
    {
        Database Baza { get; set; }
        public FormListaSablona()
        {
            InitializeComponent();
            Baza = new Database();
            gridControl1.DataSource = Baza.nalazDefault.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Radiologija.Helper.mainforma.MdiChildren.Any(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_novi"))
            {
                Radiologija.Helper.mainforma.MdiChildren.First(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_novi").Activate();
            }
            else
            {
                FormSabloni frm = new FormSabloni(false);
                frm.Tag = "Sablon_novi";
                frm.Text = "Novi obrazac";
                frm.MdiParent = Radiologija.Helper.mainforma;
                frm.Show();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Da li ste sigurni da želite obrisati selektovani obrazac?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Baza = new Database();
                    nalazDefault doktor = (nalazDefault)gridView1.GetRow(gridView1.FocusedRowHandle);
                    Baza.nalazDefault.Remove(Baza.nalazDefault.FirstOrDefault(qq => qq.id_nalazDefault == doktor.id_nalazDefault));
                    Baza.SaveChanges();
                    gridControl1.DataSource = Baza.nalazDefault.ToList();
                    gridView1.RefreshData();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Došlo je do greške prilikom brisanja podataka." + Environment.NewLine + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

                Baza = new Database();
                nalazDefault sablon = (nalazDefault)gridView1.GetRow(gridView1.FocusedRowHandle);
                FormSabloni frm = new FormSabloni(sablon);
                frm.Tag = "Sablon_edit";
                frm.Text = "Izmjena obrasca";
                frm.MdiParent = Radiologija.Helper.mainforma;
                frm.Show();
            

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var db = new Database();
            gridControl1.DataSource = db.nalazDefault.ToList();
            gridView1.RefreshData();
        }
    }
}
