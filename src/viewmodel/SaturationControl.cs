using Microsoft.AspNetCore.Components;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorImageProcessing.viewmodel
{
    public class SaturationControl : BaseImageControl, IImageControl
    {

        public string Name => "Saturation";
        public bool Show { get; set; }

        public int maxRange => 20;

        public int minRange => 1;

        public double Steps => 0.02;

        public string _imageStr { get; set; }
        public ImageProcessing _repo { get; set; }
        public float value { get; set; }

        public SaturationControl(ImageProcessing ip) :
            base(ip)
        {
            _repo = ip;
        }

        public void ProcessImage(ChangeEventArgs e)
        {
            value = EventtoValue(e);
            _repo.UpdateImage(
                 _repo.GetImage()
                 .Clone(img => img.Saturate(value))
                 ); 
        }
    }
}
