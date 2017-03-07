using System;
using UIKit;


using System.Timers;

namespace XamariniOSBlinkingAnimation
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}
				public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Timer timer = new Timer();

			timer.Interval = 500;
			timer.Start();
			timer.Elapsed += (object sender, ElapsedEventArgs e) =>
			{
				InvokeOnMainThread(() =>
				{
					if (lblBlink.TextColor == UIColor.Black)

						lblBlink.TextColor = UIColor.Red;

					else

						lblBlink.TextColor = UIColor.Black;

					if (lblAndroid.TextColor == UIColor.Black)

						lblAndroid.TextColor = UIColor.White;

					else

						lblAndroid.TextColor = UIColor.Black;

				});

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
