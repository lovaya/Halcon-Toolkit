using System;
using System.Windows.Controls;
using Halcon_Toolkit.UI.WPF;

namespace Halcon_Toolkit.Controls.WPF
{
    /// <summary>
    /// SmartWindowWPF.xaml 的交互逻辑
    /// </summary>
    public partial class SmartWindowWPF : UserControl
    {
        public HWndCtrl HalconControl;

        public SmartWindowWPF()
        {
            InitializeComponent();
        }

        private void HWindowControlWPF_OnHInitWindow(object sender, EventArgs e)
        {
            HalconControl = new HWndCtrl(DisplayWindow);
        }
    }
}
