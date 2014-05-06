// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Storybook.Touch.Views
{
	[Register("FirstView")]
	partial class FirstView
	{
		[Outlet]
		MonoTouch.UIKit.UILabel label { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}

			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}
		}
	}
}
