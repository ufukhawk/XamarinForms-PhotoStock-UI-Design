using System;
using System.Collections.Generic;
using Photostock.Model;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace Photostock.View
{
    public partial class StartPage : BaseView
    {

        public StartPage()
        {
            InitializeComponent();
            Photos.FlowItemsSource = PhotoList;
            new Animation {
            { 0, .1, new Animation (v => ProfileLayout.Opacity = v,  0 ,1) },
            { .1, .2, new Animation (v => ProfilePicture.Scale = v,0.5 , 1,Easing.CubicOut ) },
            { .2, .3, new Animation (v => UserName.Opacity = v,  0 ,1) },
            { .2, .3, new Animation (v => FollowButton.Opacity = v,  0 ,1) },
            { .2, .3, new Animation (v => FollowersLayout.Opacity = v,  0 ,1) },
            { .3, .4, new Animation (v => FollowingLayout.Opacity = v,  0 ,1) },
            { .3, .4, new Animation (v => TabsLayout.Opacity = v,  0 ,1) },
            { .3, .4, new Animation (v => TabsLayout.TranslationY = v,  10 ,0) },
            { .4, .5, new Animation (v => SearchBar.Opacity = v,  0 ,1) },
            { .4, .5, new Animation (v => SearchBar.TranslationY = v,  10 ,0) },
            { .5, .6, new Animation (v => Photos.Opacity = v,  0 ,1) },
            { .5, .6, new Animation (v => Photos.TranslationY = v,  10 ,0) },
            }.Commit(this, "Open", 16, 2000, null);
        }
        async void Photos_FlowItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var tappedItemData = e.Item as PhotoModel;
            await Navigation.PushAsync(new PhotoDetail(tappedItemData));

        }
    }
}
