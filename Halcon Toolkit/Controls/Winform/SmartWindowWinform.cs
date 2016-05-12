using System.Windows.Forms;
using Halcon_Toolkit.UI.Winform;

namespace Halcon_Toolkit.Controls.Winform
{
    public partial class SmartWindowWinform : UserControl
    {
        public HWndCtrl HalconCtrl;
        public SmartWindowWinform()
        {
            InitializeComponent();
        }

        public void InitHalconWindow()
        {
            HalconCtrl = new HWndCtrl(DisplayWindow);
        }
    }
}
