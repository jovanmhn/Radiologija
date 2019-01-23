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
    public partial class FormAddEditNalaz : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        bool isEdit { get; set; }
        nalaz nalaz { get; set; }

        public FormAddEditNalaz()
        {
            InitializeComponent();
            Baza = new Database();
            lookUpEditDoktor.Properties.DataSource = Baza.doktor.ToList();
            lookUpEditHospital.Properties.DataSource = Baza.hospital.ToList();
            lookUpEditMaska.Properties.DataSource = Baza.maska.ToList();
            lookUpEditModalitet.Properties.DataSource = Baza.modalitet.ToList();
            lookUpEditOperater.Properties.DataSource = Baza.operater.ToList();
            //lookUpEditSabloni.Properties.DataSource = Baza.nalazDefault.ToList();
            

            nalaz = new nalaz();
            nalaz.datum_pregleda = DateTime.Now;
            NalazBindingSource.DataSource = nalaz;

            
            
        }

        public FormAddEditNalaz(nalaz _nalaz)
        {
            InitializeComponent();
            Baza = new Database();
            lookUpEditDoktor.Properties.DataSource = Baza.doktor.ToList();
            lookUpEditHospital.Properties.DataSource = Baza.hospital.ToList();
            lookUpEditMaska.Properties.DataSource = Baza.maska.ToList();
            lookUpEditModalitet.Properties.DataSource = Baza.modalitet.ToList();
            lookUpEditOperater.Properties.DataSource = Baza.operater.ToList();
            //lookUpEditSabloni.Properties.DataSource = Baza.nalazDefault.ToList();
            isEdit = true;

            nalaz = Baza.nalaz.First(qq => qq.id_nalaz == _nalaz.id_nalaz);
            NalazBindingSource.DataSource = nalaz;
        }

        private void lookUpEditSabloni_EditValueChanged(object sender, EventArgs e)
        {
            int id=0;
            id = (lookUpEditSabloni.EditValue == null) ? 0 : (int)lookUpEditSabloni.EditValue;
            if(id!=0)
            {
                richEditControl1.RtfText = nalaz.nalaz_tekst = Baza.nalazDefault.FirstOrDefault(qq => qq.id_nalazDefault == id).tekst;
                richEditControl1.Refresh();
            }

            
        }



        private void lookUpEditSabloni_Enter(object sender, EventArgs e)
        {
            int id_modalitet = 0;
            int id_maska = 0;
            id_modalitet = (lookUpEditModalitet.EditValue == null) ? 0 : (int)lookUpEditModalitet.EditValue;
            id_maska = (lookUpEditMaska.EditValue == null) ? 0 : (int)lookUpEditMaska.EditValue;

            if (id_modalitet != 0 && id_maska != 0)
            {
                lookUpEditSabloni.Properties.DataSource = Baza.nalazDefault.Where(qq => qq.id_modalitet == id_modalitet && qq.id_maska == id_maska).ToList();
            }
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit && validate())
                {

                    Baza.SaveChanges();
                    XtraMessageBox.Show("Sačuvano", "Izmjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!isEdit && validate())
                {
                    Baza.nalaz.Add(nalaz);
                    Baza.SaveChanges();
                    if(XtraMessageBox.Show("Uspješno sačuvan nalaz."+Environment.NewLine+"Štampati nalaz?", "Novi nalaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new Database();                        
                        FormStampa frm = new FormStampa(db.nalaz.FirstOrDefault(qq => qq.id_nalaz == nalaz.id_nalaz));
                        //simpleButtonPrint.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Došlo je do greške prilikom izvršenja."+ Environment.NewLine+ ex.Message);
            }
        }
        public bool validate()
        {
            if (String.IsNullOrWhiteSpace(textEditIme.Text))
            {
                textEditIme.ErrorText = "Unesite vrijednost";
                return false;
            }
            if (String.IsNullOrWhiteSpace(textEditPrezime.Text))
            {
                textEditPrezime.ErrorText = "Unesite vrijednost";
                return false;
            }
            if ((int)lookUpEditHospital.EditValue == 0)
            {
                lookUpEditHospital.ErrorText = "Odabrati vrijednost";
                return false;
            }
            if ((int)lookUpEditMaska.EditValue == 0)
            {
                lookUpEditMaska.ErrorText = "Odabrati vrijednost";
                return false;
            }
            if ((int)lookUpEditModalitet.EditValue == 0)
            {
                lookUpEditModalitet.ErrorText = "Odabrati vrijednost";
                return false;
            }
            if (dateEditDatumPregleda.EditValue == null)
            {
                dateEditDatumPregleda.ErrorText = "Unijeti datum";
                return false;
            }
            if (String.IsNullOrWhiteSpace(richEditControl1.Text) )
            {
                XtraMessageBox.Show("Nalaz mora imati tekst!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
            
        }

        private void simpleButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Binding X in NalazBindingSource.CurrencyManager.Bindings)
                {
                    X.WriteValue();
                }
                var db = new Database();
                //FormStampa frm = new FormStampa(nalaz, Baza.hospital.First(qq => qq.id_hospital == (int)lookUpEditHospital.EditValue).naziv, Baza.modalitet.First(qq => qq.id_modalitet == (int)lookUpEditModalitet.EditValue).naziv, Baza.operater.First(qq => qq.id_operater == (int)lookUpEditOperater.EditValue).info_naziv, Baza.doktor.First(qq => qq.id_doktor == (int)lookUpEditDoktor.EditValue).info_naziv);
                FormStampa frm = new FormStampa(db.nalaz.FirstOrDefault(qq => qq.id_nalaz == nalaz.id_nalaz));
                //frm.ShowDialog();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void textEditIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                textEditPrezime.Focus(); 
            }
        }

        private void textEditPrezime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateEditDatumRodj.Focus();
            }
        }

        private void dateEditDatumRodj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateEditDatumPregleda.Focus();
            }
        }

        private void lookUpEditModalitet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditHospital.Focus();
            }
        }

        private void lookUpEditHospital_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditMaska.Focus();
            }
        }

        private void lookUpEditMaska_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditSabloni.Focus();
            }
        }

        private void lookUpEditSabloni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditOperater.Focus();
            }
        }

        private void lookUpEditOperater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditDoktor.Focus();
            }
        }

        private void lookUpEditDoktor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButtonSave.Focus();
            }
        }

        private void dateEditDatumPregleda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditModalitet.Focus();
            }
        }
    }
}
