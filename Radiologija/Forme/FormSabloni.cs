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
        int id_modalitet { get; set; }
        int id_maska { get; set; }

        public FormSabloni(bool _isEdit)
        {
            InitializeComponent();
            Baza = new Database();
            modalitetBindingSource.DataSource = Baza.modalitet.ToList();
            maskaBindingSource.DataSource = Baza.maska.ToList();
            nalazdefault = new nalazDefault();
            isEdit = _isEdit;
            if (!isEdit)
            {
                labelControl3.Visible = lookUpEdit3.Visible = simpleButton1.Visible = false;
                nalazdefault = new nalazDefault();

                DefaultbindingSource.DataSource = nalazdefault;
            }
        }
        public FormSabloni (nalazDefault _nalaz)
        {
            InitializeComponent();
            Baza = new Database();
            modalitetBindingSource.DataSource = Baza.modalitet.ToList();
            maskaBindingSource.DataSource = Baza.maska.ToList();
            nalazdefault = Baza.nalazDefault.FirstOrDefault(qq => qq.id_nalazDefault == _nalaz.id_nalazDefault);
            DefaultbindingSource.DataSource = Baza.nalazDefault.FirstOrDefault(qq => qq.id_nalazDefault == _nalaz.id_nalazDefault);
            labelControl3.Visible = lookUpEdit3.Visible = simpleButton1.Visible = false;
            isEdit = true;
            lookUpEdit1.EditValue = _nalaz.id_modalitet;
            lookUpEdit2.EditValue = _nalaz.id_maska;

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
            if(isEdit)
            {
                lookUpEdit3.Properties.DataSource = Baza.nalazDefault.Where(qq => qq.id_modalitet == (int)lookUpEdit1.EditValue && qq.id_maska == (int)lookUpEdit2.EditValue).ToList();
            }
            


            


        kraj:;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                try
                {
                    nalazdefault.id_modalitet = (int)lookUpEdit1.EditValue;
                    nalazdefault.id_maska = (int)lookUpEdit2.EditValue;
                    Baza.SaveChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message,"Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    goto kraj;
                }
                if (XtraMessageBox.Show("Uspješno izmijenjen obrazac.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                try
                {

                    nalazdefault.id_modalitet = (int)lookUpEdit1.EditValue;
                    nalazdefault.id_maska = (int)lookUpEdit2.EditValue;
                    foreach(Binding X in DefaultbindingSource.CurrencyManager.Bindings)
                    {
                        X.WriteValue();
                    }
                    var test = textEdit1.Text;
                    Baza.nalazDefault.Add(nalazdefault);
                    Baza.SaveChanges();
                    
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto kraj;
                }
                if(XtraMessageBox.Show("Obrazac"+System.Environment.NewLine+nalazdefault.naziv+System.Environment.NewLine+"Uspješno dodat.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }

            }



            kraj:;
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            if (isEdit)
            {
                nalazdefault = Baza.nalazDefault.FirstOrDefault(qq => qq.id_nalazDefault == (int)lookUpEdit3.EditValue);
                textEdit1.Text = nalazdefault.naziv;
                richEditControl1.RtfText = nalazdefault.tekst;

                DefaultbindingSource.DataSource = nalazdefault; 
            }
        }
    }
}
