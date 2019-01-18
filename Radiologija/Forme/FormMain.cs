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
            Radiologija.Helper.mainforma = this;
            
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
            if (barToggleSwitchItem1.Checked == false) ribbonPage3.Visible = false;
            else
            {
                FormPassCheck frm = new FormPassCheck();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ribbonPage3.Visible = true;
                }
                else
                {
                    barToggleSwitchItem1.Checked = false;
                }
            }
            
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
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_novi"))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_novi").Activate();
            }
            else
            {
                FormSabloni frm = new FormSabloni(false);
                frm.Tag = "Sablon_novi";
                frm.Text = "Novi obrazac";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItemIzmijeniSablon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_edit"))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormSabloni) && qq.Tag.ToString() == "Sablon_edit").Activate();
            }
            else
            {
                FormSabloni frm = new FormSabloni(true);
                frm.Tag = "Sablon_edit";
                frm.Text = "Izmjena obrasca";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormAddEditNalaz)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormAddEditNalaz)).Activate();
            }
            else
            {
                FormAddEditNalaz frm = new FormAddEditNalaz();
                frm.Text = "Novi nalaz";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormArhiva)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormArhiva)).Activate();
            }
            else
            {
                FormArhiva frm = new FormArhiva();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var db = new Database();
            if (!String.IsNullOrEmpty(db.settings.FirstOrDefault(qq => qq.naziv == "theme").vrijednost))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = db.settings.FirstOrDefault((qq => qq.naziv == "theme")).vrijednost;
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormSettings)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormSettings)).Activate();
            }
            else
            {
                FormSettings frm = new FormSettings();
                frm.Text = "Podešavanja";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItemListaObrazaca_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Any(qq => qq.GetType() == typeof(FormListaSablona)))
            {
                this.MdiChildren.First(qq => qq.GetType() == typeof(FormListaSablona)).Activate();
            }
            else
            {
                FormListaSablona frm = new FormListaSablona();
                frm.Text = "Lista obrazaca";
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
