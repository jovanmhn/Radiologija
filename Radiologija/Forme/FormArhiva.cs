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
    public partial class FormArhiva : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        public FormArhiva()
        {
            InitializeComponent();
            Baza = new Database();
            gridControl1.DataSource = Baza.nalaz.ToList();
            gridView1.RefreshData();
            gridView1.BestFitColumns();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Da li ste sigurni da želite obrisati nalaz?", "Potvrda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = (nalaz)gridView1.GetRow(gridView1.FocusedRowHandle);
                    Baza.nalaz.Remove(Baza.nalaz.First(qq => qq.id_nalaz == row.id_nalaz));
                    Baza.SaveChanges();
                    XtraMessageBox.Show("Nalaz obrisan", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButton4.PerformClick();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Došlo je do greške prilikom brisanja nalaza" + Environment.NewLine + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var row = (nalaz)gridView1.GetRow(gridView1.FocusedRowHandle);
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormAddEditNalaz) && qq.Tag.ToString() == row.id_nalaz.ToString()))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormAddEditNalaz) && qq.Tag.ToString() == row.id_nalaz.ToString()).Activate();
            }
            else
            {
                FormAddEditNalaz frm = new FormAddEditNalaz(row);
                frm.Tag = row.id_nalaz.ToString();
                frm.Text = String.Format("Nalaz br.{0}, ({1} {2})",row.id_nalaz, row.ime, row.prezime);
                frm.MdiParent = Radiologija.Helper.mainforma;
                frm.Show();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormAddEditNalaz)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormAddEditNalaz)).Activate();
            }
            else
            {
                FormAddEditNalaz frm = new FormAddEditNalaz();
                frm.Text = "Novi nalaz";
                frm.MdiParent = Radiologija.Helper.mainforma; 
                frm.Show();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Baza = new Database();
            gridControl1.DataSource = Baza.nalaz.ToList();
            gridView1.RefreshData();
            gridView1.BestFitColumns();
        }

        private void barButtonItemOtvori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButton2.PerformClick();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButton4.PerformClick();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Da li ste sigurni da želite obrisati nalaz?", "Potvrda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = (nalaz)gridView1.GetRow(gridView1.FocusedRowHandle);
                    Baza.nalaz.Remove(Baza.nalaz.First(qq => qq.id_nalaz == row.id_nalaz));
                    Baza.SaveChanges();
                    XtraMessageBox.Show("Nalaz obrisan", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButton4.PerformClick();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Došlo je do greške prilikom brisanja nalaza" + Environment.NewLine + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            var pt = view.GridControl.PointToClient(Control.MousePosition);
            var hitInfo = view.CalcHitInfo(pt);

            if (hitInfo.InDataRow && (hitInfo.InRow || hitInfo.InRowCell))
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                if (e.Button == MouseButtons.Right && e.Clicks == 1)
                {
                    popupMenu1.ShowPopup(MousePosition);
                }
                else if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    var row = (nalaz)gridView1.GetRow(gridView1.FocusedRowHandle);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = (nalaz)gridView1.GetRow(gridView1.FocusedRowHandle);
            FormStampa frm = new FormStampa(row);
            //frm.ShowDialog();
        }
    }
}
