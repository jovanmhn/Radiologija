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
    public partial class FormAddEditDoktor : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        bool isEdit { get; set; }
        doktor doktor { get; set; }

        public FormAddEditDoktor()
        {
            InitializeComponent();
            Baza = new Database();
            isEdit = false;
            doktor = new doktor();
            DoktorBindingSource.DataSource = doktor;
            this.Text="Novi doktor";
        }
        public FormAddEditDoktor(doktor _doktor)
        {
            InitializeComponent();
            Baza = new Database();
            isEdit = true;
            doktor = Baza.doktor.FirstOrDefault(qq => qq.id_doktor == _doktor.id_doktor);
            DoktorBindingSource.DataSource = doktor;
            this.Text = "Izmjena";
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
                    Baza.doktor.Add(doktor);
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
