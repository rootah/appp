using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appp
{
    public partial class initform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public initform()
        {
            InitializeComponent();
            backsettings1.mainform = this;
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.ShowApplicationButtonContentControl();
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Close();
        }

        private void groupCheckBtn_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (groupCheckBtn.Checked)
                dockManager1.Panels["groupPanel"].Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            else dockManager1.Panels["groupPanel"].Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        private void groupPanel_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            groupCheckBtn.Checked = false;
        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stdsCheckBtn.Checked)
                dockManager1.Panels["stdsPanel"].Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            else dockManager1.Panels["stdsPanel"].Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

        }

        private void stdsPanel_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            stdsCheckBtn.Checked = false;
        }

        private void navBarGroup2_ItemChanged(object sender, EventArgs e)
        {
            if (navBarGroup2.SelectedLink == null)
                return;
            var slctd = navBarGroup2.SelectedLink.Caption;
            stdsGroupText.Caption = slctd;
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
