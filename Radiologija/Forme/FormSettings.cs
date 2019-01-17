using DevExpress.Skins;
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
    public partial class FormSettings : DevExpress.XtraEditors.XtraForm
    {
        public string skinName_old;
        public FormSettings()
        {
            InitializeComponent();

            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {

                List<string> listaskinova = new List<string>();
                listaskinova.Add(cnt.SkinName);

                comboBoxEdit1.Properties.Items.AddRange(listaskinova);
            }
            skinName_old = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string skinName = comboBoxEdit1.EditValue.ToString();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var db = new Database();
            db.settings.FirstOrDefault(qq => qq.naziv == "theme").vrijednost = comboBoxEdit1.EditValue.ToString();
            db.SaveChanges();
            skinName_old = comboBoxEdit1.EditValue.ToString();
            XtraMessageBox.Show("Izmijenjeno.");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName_old;
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName_old;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textEdit1.Text))
            {
                XtraMessageBox.Show("Lozinka ne smije biti prazno polje!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto kraj;
            }
            if (textEdit1.Text == textEdit2.Text)
            {
                var db = new Database();
                db.settings.FirstOrDefault(qq=> qq.naziv == "adminPass").vrijednost = textEdit1.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Izmijenjeno.");
            }
            else
            {
                XtraMessageBox.Show("Unešene lozinke se ne poklapaju!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        kraj:;
        }
    }
}
