using Microsoft.AspNetCore.Components;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazorImageProcessing.viewmodel
{
    public abstract class BaseImageControl
    {
        public BaseImageControl(ImageProcessing ip)
        {
        }

        protected float EventtoValue(ChangeEventArgs e)
        {
            return float.Parse(e.Value.ToString());
        }
    }
}
