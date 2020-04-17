using System;
using System.Collections.Generic;
using Photostock.Model;
using Xamarin.Forms;

namespace Photostock.View
{
    public partial class PhotoDetail
    {

        bool isOpen;
        public PhotoDetail(PhotoModel photoModel)
        {
            InitializeComponent();
            BindingContext = photoModel;
            Device.BeginInvokeOnMainThread(() =>
            {
                new Animation {
            { 0, .1, new Animation (v => ItemImage.Scale = v,1 , 1.3) },
            }.Commit(this, "Scale", 16, 300000,null, null, null);
            });

            new Animation {
            { 0, .1, new Animation (v => DetailPopup.TranslationY = v,90 , 0 ) },
            }.Commit(this, "Translate", 16, 2000, null);
        }
        void ExpandPopup(System.Object sender = null, System.EventArgs e = null)
        {
            isOpen = isOpen == false;
            new Animation {
            { 0, .1, new Animation (v => ExpandPopupLayout.Scale = v,0.7 , 1 ) },
            {  0, .1, new Animation (v => DetailPopup.HeightRequest = v, isOpen ? 50 : 400 ,isOpen ? 400 : 50 ,isOpen ?  Easing.CubicIn :Easing.CubicOut ) },
            { .1, .2, new Animation (v => DetailLayout.Opacity = v, isOpen ? 0 : 1  , isOpen ? 1 : 0 ) },
            { .2, .3, new Animation (v => DetailInfoLayout.Opacity = v, isOpen ? 0 : 1  , isOpen ? 1 : 0 ) },
            { .3, .4, new Animation (v => ImagesLayout.Opacity = v, isOpen ? 0 : 1  , isOpen ? 1 : 0 ) },
            }.Commit(this, "PopupOpen", 16, 2000, null);

        }

        void Back(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
