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
    public partial class FormMaske : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        public FormMaske()
        {
            InitializeComponent();
            Baza = new Database();
            gridControl1.DataSource = Baza.maska.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAddEditMaske frm = new FormAddEditMaske();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.maska.ToList();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            maska maska = (maska)gridView1.GetRow(gridView1.FocusedRowHandle);
            FormAddEditMaske frm = new FormAddEditMaske(maska);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.maska.ToList();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Da li ste sigurni da želite obrisati selektovanu masku?","?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                maska maska = (maska)gridView1.GetRow(gridView1.FocusedRowHandle);
                Baza = new Database();
                try
                {
                    Baza = new Database();
                    Baza.maska.Remove(Baza.maska.FirstOrDefault(qq => qq.id_maska == maska.id_maska));
                    Baza.SaveChanges();
                    gridControl1.DataSource = Baza.maska.ToList();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Došlo je do greške prilikom brisanja podataka." + Environment.NewLine + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
