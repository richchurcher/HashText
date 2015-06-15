using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HashText
{
	[Activity (Label = "HashText", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			EditText input = FindViewById<EditText> (Resource.Id.textToHash);
			Button button = FindViewById<Button> (Resource.Id.SHAButton);
			TextView hash = FindViewById <TextView> (Resource.Id.HashText);
			
			button.Click += delegate {
				hash.Text = Hasher.HashString(input.Text);
			};
		}
	}
}


