﻿using System;

using UIKit;

namespace Sample_XI_CustomView
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle)
			: base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			//customView.myButton.BackgroundColor = UIColor.Red;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

