using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Create the user interface in code
            string defaultText = "Hello, Xamarin.Android";
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            var aLabel = new TextView(this);
            aLabel.Text = defaultText;
            var aButton = new Button(this);
            aButton.Text = "Say Hello";
            var aResetButton = new Button(this);
            aResetButton.Text = "Reset";
            aButton.Click += (sender, e) =>
            {
                aLabel.Text = "Hello from the button";
            };

            aResetButton.Click += (sender, e) =>
            {
                aLabel.Text = defaultText;
            };

            layout.AddView(aLabel);
            layout.AddView(aButton);
            layout.AddView(aResetButton);
            SetContentView(layout);
        }

    }
}

