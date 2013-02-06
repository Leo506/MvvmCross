using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using TwitterSearch.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using System.Collections.Generic;
using Cirrious.MvvmCross.Views;

namespace TwitterSearch.UI.Touch.Views
{
    public sealed partial class HomeView 
        : MvxBindingViewController
    {
        public HomeView ()
            : base ("HomeView", null)
        {
            Title = "Home";
        }
        
		public new HomeViewModel ViewModel {
			get { return (HomeViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            
            this.AddBindings(new Dictionary<object, string>()
            {
                { Go, "TouchUpInside SearchCommand"}, 
                { Random, "TouchUpInside PickRandomCommand"}, 
                { Edit, "Text SearchText"}, 
            });
        }
        
        public override void ViewDidUnload ()
        {
            base.ViewDidUnload ();
            
            ReleaseDesignerOutlets ();
        }
        
        public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
    }
}

