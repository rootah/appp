using System;
using DevExpress.XtraEditors;

namespace appp
{
    public partial class backsettings : XtraUserControl
    {
        public initform mainform { get; set; }
        public backsettings()
        {
            InitializeComponent();
            
        }

        private void headerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mainform == null)
                return;
            if (headerCheck.Checked)
            {
                mainform.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
                mainform.appmenuPageGroup.Visible = false;
            }
            else
            {
                mainform.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
                mainform.appmenuPageGroup.Visible = true;
            }
        }
    }
}
