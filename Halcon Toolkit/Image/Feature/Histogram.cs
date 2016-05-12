using System;
using System.Collections.Generic;
using LiveCharts;
using HalconDotNet;

namespace Halcon_Toolkit.Image.Feature
{
    /// <summary>
    /// This is a LiveCharts Histogram Controls
    /// link a image object
    /// quick to see Histogram
    /// </summary>
	public class Histogram : SeriesCollection, IDisposable
    {
        public readonly int ImageChannels;
        public readonly List<double>[] AbGrayValue;
        public readonly List<double>[] ReGrayValue;
        public readonly HObject[] GrayPlane;
        public readonly HObject Image;
        private HObject _fullRegion;
        private LineSeries[] _lineSeries;

        /// <summary>
        /// Constructor with HObject
        /// </summary>
        /// <param name="obj"></param>
	    public Histogram(HObject obj)
        {
            Image = obj;
            ImageChannels = CountChannels();
            GetFullRegion();
            if (ImageChannels > 0)
            {
                var functionName = "Decompose" + ImageChannels;
                GrayPlane = new HObject[ImageChannels];
                CreateGrayValueArray(ref AbGrayValue);
                CreateGrayValueArray(ref ReGrayValue);
                GetType().GetMethod(functionName).Invoke(this, new object[] { });
                for (var i = 0; i < GrayPlane.Length; i++)
                    GrayHisto(i);
                _lineSeries = new LineSeries[ImageChannels];
                for (int i = 0; i < ImageChannels; i++)
                {
                    _lineSeries[i] = new LineSeries
                    {
                        Title = "Charles",
                        Values = new ChartValues<double>().AddRange(ReGrayValue[i])
                    };
                    Add(_lineSeries[i]);
                }
            }
        }

        public void Decompose1()
        {
            GrayPlane[0] = Image;
        }
        public void Decompose2()
        {
            HOperatorSet.Decompose2(Image, out GrayPlane[0], out GrayPlane[1]);
        }
        public void Decompose3()
        {
            HOperatorSet.Decompose3(Image, out GrayPlane[0], out GrayPlane[1], out GrayPlane[2]);
        }
        public void Decompose4()
        {
            HOperatorSet.Decompose4(Image, out GrayPlane[0], out GrayPlane[1], out GrayPlane[2], out GrayPlane[3]);
        }
        public void Decompose5()
        {
            HOperatorSet.Decompose5(Image, out GrayPlane[0], out GrayPlane[1], out GrayPlane[2], out GrayPlane[3], out GrayPlane[4]);
        }
        public void Decompose6()
        {
            HOperatorSet.Decompose6(Image, out GrayPlane[0], out GrayPlane[1], out GrayPlane[2], out GrayPlane[3], out GrayPlane[4], out GrayPlane[5]);
        }
        public void Decompose7()
        {
            HOperatorSet.Decompose7(Image, out GrayPlane[0], out GrayPlane[1], out GrayPlane[2], out GrayPlane[3], out GrayPlane[4], out GrayPlane[5], out GrayPlane[6]);
        }
        private int CountChannels()
        {
            HTuple channels;
            HOperatorSet.CountChannels(Image, out channels);
            return channels.I;
        }
        private void GetFullRegion()
        {
            HTuple width, height;
            HOperatorSet.GetImageSize(Image, out width, out height);
            HOperatorSet.GenRectangle1(out _fullRegion, 0, 0, height, width);
        }
        private void GrayHisto(int index)
        {
            HTuple absolute, relative;
            HOperatorSet.GrayHisto(_fullRegion, GrayPlane[index], out absolute, out relative);
            foreach (var v in absolute.ToDArr())
            {
                AbGrayValue[index].Add(v);
            }
            foreach (var v in relative.ToDArr())
            {
                ReGrayValue[index].Add(v);
            }
        }
        private void CreateGrayValueArray(ref List<double>[] value)
        {
            value = new List<double>[ImageChannels];
            for (var i = 0; i < value.Length; i++)
                value[i] = new List<double>();
        }

        public void Dispose()
        {
            foreach (var obj in GrayPlane)
                obj?.Dispose();
            Image?.Dispose();
            _fullRegion?.Dispose();
        }
    }//end of class
}//end of namespace
