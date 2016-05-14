using HalconDotNet;

namespace Halcon_Toolkit.Image.Acquisition
{
    public interface IFrameGrabber
    {
        void OpenCamera();
        void CloseCamera();
        HObject SnapImage();
    }
}
