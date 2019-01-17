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
    public partial class FormAddEditMaske : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        bool isEdit;
        maska maska { get; set; }

        public FormAddEditMaske()
        {
            Baza = new Database();
            maska = new maska();
            InitializeComponent();
            isEdit = false;
            MaskeBindingSource.DataSource = maska;
        }

        public FormAddEditMaske(maska _maska)
        
        {
            InitializeComponent();
            Baza = new Database();
            isEdit = true;
            maska = _maska;
            MaskeBindingSource.DataSource = Baza.maska.FirstOrDefault(qq=> qq.id_maska == _maska.id_maska);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit && validateime(maska))
                {
                    Baza.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                if(!isEdit && validateime())
                {
                    Baza.maska.Add(maska);
                    Baza.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Došlo je do greške prilikom čuvanja podataka." + Environment.NewLine + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validateime()
        {
            var db = new Database();
            List<string> lista = db.maska.Select(qq=> qq.naziv).ToList();
            if (lista.Contains(maska.naziv))
            {
                XtraMessageBox.Show("Već postoji maska sa tim imenom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool validateime(maska maska)
        {
            var db = new Database();
            List<string> lista = db.maska.Where(qq=> qq.id_maska != maska.id_maska).Select(qq => qq.naziv).ToList();
            if (lista.Contains(Baza.maska.FirstOrDefault(qq => qq.id_maska == maska.id_maska).naziv))
            {
                XtraMessageBox.Show("Već postoji maska sa tim imenom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
