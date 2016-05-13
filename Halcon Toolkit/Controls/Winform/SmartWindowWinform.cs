using System.Windows.Forms;
using HalconDotNet;
using Halcon_Toolkit.UI.Winform;

namespace Halcon_Toolkit.Controls.Winform
{
    public partial class SmartWindowWinform : UserControl
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

        public SmartWindowWinform()
        {
            InitializeComponent();
        }

        public void UpdateWindow()
        {
            HalconCtrl.repaint();
        }

        public void InitHalconWindow()
        {
            HalconCtrl = new HWndCtrl(DisplayWindow);
        }
    }
}
