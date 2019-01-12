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
        private Dictionary<Type, Point> FormSizes { get; set; }
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormMaske)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormMaske)).Activate();
            }
            else
            {
                FormMaske frm = new FormMaske();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormOperateri)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormOperateri)).Activate();
            }
            else
            {
                FormOperateri frm = new FormOperateri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormDoktori)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormDoktori)).Activate();
            }
            else
            {

                FormDoktori frm = new FormDoktori();
            frm.MdiParent = this;
            frm.Show();
            }
        }



        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            ribbonPage3.Visible = barToggleSwitchItem1.Checked;
        }

        private void CheckMdi()
        {
            if (this.MdiChildren.Count() == 0)
            {
                pictureBox1.Visible = true;
            }
        }

        private void CheckMdiEvent(object sender, System.EventArgs e)
        {
            CheckMdi();
        }

        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (FormSizes == null) FormSizes = new Dictionary<Type, Point>();

                if (!FormSizes.ContainsKey(this.ActiveMdiChild.GetType())) FormSizes.Add(this.ActiveMdiChild.GetType(), new Point(this.ActiveMdiChild.Width, this.ActiveMdiChild.Height));

                pictureBox1.Visible = false;

                this.ActiveMdiChild.Disposed -= new EventHandler(this.CheckMdiEvent);
                this.ActiveMdiChild.Disposed += new EventHandler(this.CheckMdiEvent);
            }
        }

        private void barButtonItemDodajSablon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormSabloni)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormSabloni)).Activate();
            }
            else
            {
                FormSabloni frm = new FormSabloni(false);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItemIzmijeniSablon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormSabloni)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormSabloni)).Activate();
            }
            else
            {
                FormSabloni frm = new FormSabloni(true);
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
