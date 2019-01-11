using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Radiologija
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMaske frm = new FormMaske();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormOperateri frm = new FormOperateri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDoktori frm = new FormDoktori();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
