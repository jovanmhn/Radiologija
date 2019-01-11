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
            MaskeBindingSource.DataSource = Baza.maska.FirstOrDefault(qq=> qq.id_maska == _maska.id_maska);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    Baza.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
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
    }
}
