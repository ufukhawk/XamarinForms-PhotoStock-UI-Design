using System;
using System.Collections.Generic;
using Photostock.Model;
using Xamarin.Forms;

namespace Photostock.View
{
    public class BaseView : ContentPage
    {
        public List<ImageGallery> MaleImageGalleryList = new List<ImageGallery>();
        public List<ImageGallery> FemaleImageGalleryList = new List<ImageGallery>();
        private double ItemHeight = 180;
        public List<PhotoModel> PhotoList = new List<PhotoModel>();
        public BaseView()
        {
            FemaleImageGalleryList.Add(new ImageGallery
            {
                Image = "k1.jpg"
            });
            FemaleImageGalleryList.Add(new ImageGallery
            {
                Image = "k2.jpg"
            });
            FemaleImageGalleryList.Add(new ImageGallery
            {
                Image = "k3.jpg"
            });
            MaleImageGalleryList.Add(new ImageGallery
            {
                Image = "e1.jpg"
            });
            MaleImageGalleryList.Add(new ImageGallery
            {
                Image = "e2.jpg"
            });
            MaleImageGalleryList.Add(new ImageGallery
            {
                Image = "e3.jpg"
            });
            PhotoList.Add(new PhotoModel
            {
                Image = "e1.jpg",
                Category = "Male Fashion",
                Title = "Red Mens T-shirt",
                ImageGalleries = MaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight
            });
            PhotoList.Add(new PhotoModel
            {
                Image = "e2.jpg",
                Category = "Male Fashion",
                Title = "Black Mens T-shirt",
                ImageGalleries = MaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight
            });
            PhotoList.Add(new PhotoModel
            {
                Image = "e3.jpg",
                Category = "Male Fashion",
                Title = "White Mens T-shirt",
                ImageGalleries = MaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight

            });
            PhotoList.Add(new PhotoModel
            {
                Image = "k1.jpg",
                Category = "Female Fashion",
                Title = "Light Grey Women T-shirt",
                ImageGalleries = FemaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight
            });
            PhotoList.Add(new PhotoModel
            {
                Image = "k2.jpg",
                Category = "Female Fashion",
                Title = "White Women T-shirt",
                ImageGalleries = FemaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight
            });
            PhotoList.Add(new PhotoModel
            {
                Image = "k3.jpg",
                Category = "Female Fashion",
                Title = "White Women T-shirt",
                ImageGalleries = FemaleImageGalleryList,
                Id = Guid.NewGuid().ToString(),
                ItemHeight = ItemHeight
            });
        }
    }
}
