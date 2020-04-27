using Microsoft.AspNetCore.Components;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorImageProcessing.viewmodel
{
    public interface IImageControl
    {
        public ImageProcessing _repo { get; set; }
        public float value { get; set; }
        public string Name { get;}
        public bool Show { get; set; }

        public int maxRange { get;}

        public int minRange { get;}

        public double Steps { get; }

        public void ProcessImage(ChangeEventArgs e);


    }
}
