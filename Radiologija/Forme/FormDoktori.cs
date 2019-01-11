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
    public partial class FormDoktori : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        public FormDoktori()
        {
            InitializeComponent();
            Baza = new Database();
            gridControl1.DataSource = Baza.doktor.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            doktor doktor = (doktor)gridView1.GetRow(gridView1.FocusedRowHandle);
            FormAddEditDoktor frm = new FormAddEditDoktor(doktor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.doktor.ToList();
                gridView1.RefreshData();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAddEditDoktor frm = new FormAddEditDoktor();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.doktor.ToList();
                gridView1.RefreshData();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Da li ste sigurni da želite obrisati selektovanog operatera?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Baza = new Database();
                    doktor doktor = (doktor)gridView1.GetRow(gridView1.FocusedRowHandle);
                    Baza.doktor.Remove(Baza.doktor.FirstOrDefault(qq => qq.id_doktor == doktor.id_doktor));
                    Baza.SaveChanges();
                    gridControl1.DataSource = Baza.doktor.ToList();
                    gridView1.RefreshData();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Došlo je do greške prilikom brisanja podataka." + Environment.NewLine + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
