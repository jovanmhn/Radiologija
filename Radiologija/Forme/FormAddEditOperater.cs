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
    public partial class FormAddEditOperater : DevExpress.XtraEditors.XtraForm
    {
        Database Baza { get; set; }
        bool isEdit;
        operater operater { get; set; }

        public FormAddEditOperater()
        {
            Baza = new Database();
            operater = new operater();
            InitializeComponent();
            isEdit = false;
            operaterBindingSource.DataSource = operater;
            this.Text = "Novi operater";
        }
        public FormAddEditOperater(operater _operater)
        {
            Baza = new Database();
            operater = _operater;
            InitializeComponent();
            isEdit = true;
            operaterBindingSource.DataSource = Baza.operater.FirstOrDefault(qq=> qq.id_operater == operater.id_operater);
            this.Text = "Izmjena operatera";
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
                    Baza.operater.Add(operater);
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
