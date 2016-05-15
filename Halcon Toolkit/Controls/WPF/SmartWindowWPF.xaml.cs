using System;
using System.Windows.Controls;
using HalconDotNet;
using Halcon_Toolkit.UI.WPF;

namespace Halcon_Toolkit.Controls.WPF
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class SmartWindowWPF : UserControl
    {
        public HWndCtrl HalconCtrl;

        public HObject RuntimeImage
        {
            set
            {
                HalconCtrl.clearList();
                using (var image = new HImage(value))
                {
                    HalconCtrl.addIconicVar(image);
                    HalconCtrl.repaint();
                }
            }
        }

        public SmartWindowWPF()
        {
            InitializeComponent();
        }

        public void UpdateWindow()
        {
            HalconCtrl.repaint();
        }

        public void AddSingleObject(HObject obj)
        {
            HalconCtrl.clearList();
            using (var image = new HImage(obj))
            {
                HalconCtrl.addIconicVar(image);
                HalconCtrl.repaint();
            }
        }

        private void HWindowControlWPF_OnHInitWindow(object sender, EventArgs e)
        {
            HalconCtrl = new HWndCtrl(DisplayWindow);
        }
    }
}
