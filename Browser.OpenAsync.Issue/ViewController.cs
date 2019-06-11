using Foundation;
using System;
using UIKit;
using Xamarin.Essentials;

namespace Browser.OpenAsync.Issue
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            clickMe.TouchUpInside += ClickMe_TouchUpInside;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        void ClickMe_TouchUpInside(object sender, EventArgs e)
        {
            Xamarin.Essentials.Browser.OpenAsync("https://github.com/xamarin/Essentials/blob/master/SUBMITTING-ISSUES.md#ios-specific-concerns", new BrowserLaunchOptions
            {
                TitleMode = BrowserTitleMode.Show,
                LaunchMode = BrowserLaunchMode.External
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}