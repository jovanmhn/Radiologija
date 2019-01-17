using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Radiologija
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRLabel Napomena_label { get { return this.xrLabel22; } }
        public XRLabel Napomena_label2 { get { return this.xrLabel23; } }
        public XtraReport1()
        {
            InitializeComponent();
        }

    }
}
