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
    public partial class FormPassCheck : Form
    {
        public FormPassCheck()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new Database();
            if (textEdit1.Text != db.settings.FirstOrDefault((qq => qq.naziv == "adminPass")).vrijednost)
            {
                XtraMessageBox.Show("Pogrešna lozinka!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) simpleButton1.PerformClick();
        }
    }
}
