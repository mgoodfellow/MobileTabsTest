using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;

namespace MobileTabTest.Droid
{
    [Activity(
        Label = "MobileTabTest.Droid", 
        Icon = "@drawable/icon", 
        Theme = "@style/AppTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask)]
    public class FormsActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
        }

        public override void OnBackPressed()
        {
            MoveTaskToBack(false);
        }
    }
}
