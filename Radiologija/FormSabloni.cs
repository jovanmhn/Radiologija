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
    public partial class FormSabloni : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        nalazDefault nalazdefault { get; set; }
        bool isEdit { get; set; }

        public FormSabloni()
        {
            InitializeComponent();
            Baza = new Database();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(lookUpEdit1.EditValue == null)
            {
                lookUpEdit1.ErrorText = "Morate odabrati vrijednost!";
                goto kraj;
            }
            if (lookUpEdit2.EditValue == null)
            {
                lookUpEdit1.ErrorText = "Morate odabrati vrijednost!";
                goto kraj;
            }
            if(Baza.nalazDefault.FirstOrDefault(qq => qq.id_modalitet == (int)lookUpEdit1.EditValue && qq.id_maska == (int)lookUpEdit2.EditValue).id_nalazDefault != 0)
            {
                nalazdefault = Baza.nalazDefault.FirstOrDefault(qq => qq.id_modalitet == (int)lookUpEdit1.EditValue && qq.id_maska == (int)lookUpEdit2.EditValue);
                textEdit1.Text = nalazdefault.naziv;
                richEditControl1.RtfText = Baza.nalazDefault.FirstOrDefault(qq => qq.id_modalitet == (int)lookUpEdit1.EditValue && qq.id_maska == (int)lookUpEdit2.EditValue).tekst ?? String.Empty;
                isEdit = true;
                DefaultbindingSource.DataSource = nalazdefault;
            }
            else
            {
                nalazdefault = new nalazDefault();
                isEdit = false;
                DefaultbindingSource.DataSource = nalazdefault;
            }

            


        kraj:;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textEdit1.Text))
            {
                textEdit1.ErrorText = "Morate unijeti naslov";
                goto kraj;
                
            }
            if (isEdit)
            {
                try
                {
                    Baza.SaveChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message,"Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    goto kraj;
                }
                XtraMessageBox.Show("Uspješno izmijenjen šablon.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }



            kraj:;
        }
    }
}
