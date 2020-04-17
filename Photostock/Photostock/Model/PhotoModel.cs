using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Photostock.Model
{
    public class PhotoModel
    {
        public string Image { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double ItemHeight { get; set; }
        public List<ImageGallery> ImageGalleries { get; set; }
        public PhotoModel()
        {
            ImageGalleries = new List<ImageGallery>();
        }
    }
}
