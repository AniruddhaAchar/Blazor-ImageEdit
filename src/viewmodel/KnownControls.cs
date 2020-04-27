using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blazorImageProcessing.viewmodel
{
    public class KnownControls
    {
        private readonly List<IImageControl> controlList;
        public KnownControls(ImageProcessing ip)
        {
            controlList = new List<IImageControl>();
            controlList.Add(new HueControl(ip));
            controlList.Add(new SaturationControl(ip));
            controlList.Add(new BrightnessControl(ip));
        }

        public List<IImageControl> GetImageControls()
        {
            return controlList;
        }

    }
}
