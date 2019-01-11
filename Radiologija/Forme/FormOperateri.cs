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
    public partial class FormOperateri : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        public FormOperateri()
        {
            InitializeComponent();
            Baza = new Database();
            gridControl1.DataSource = Baza.operater.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAddEditOperater frm = new FormAddEditOperater();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.operater.ToList();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            operater operater = (operater)gridView1.GetRow(gridView1.FocusedRowHandle);
            FormAddEditOperater frm = new FormAddEditOperater(operater);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Baza = new Database();
                gridControl1.DataSource = Baza.operater.ToList();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Da li ste sigurni da želite obrisati selektovanog operatera?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operater operater = (operater)gridView1.GetRow(gridView1.FocusedRowHandle);
                Baza = new Database();
                try
                {
                    Baza = new Database();
                    Baza.operater.Remove(Baza.operater.FirstOrDefault(qq => qq.id_operater == operater.id_operater));
                    Baza.SaveChanges();
                    gridControl1.DataSource = Baza.operater.ToList();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Došlo je do greške prilikom brisanja podataka." + Environment.NewLine + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
