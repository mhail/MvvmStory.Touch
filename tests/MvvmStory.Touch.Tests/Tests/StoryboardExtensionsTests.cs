using System;
using NUnit.Framework;
using MvvmStory.Touch;

namespace MvvmStory.Touch.Tests
{
	[TestFixture]
	public class StoryboardExtensionsTests
	{
		[Test]
		public void LoadRootViewControllerByTypeName ()
		{
			var vc = typeof(TestViewController).LoadFromStoryboard ();
			Assert.IsNotNull (vc, "Type load from storyboard failed");
			if (null != vc)
				vc.Dispose ();
		}

		[Test]
		public void LoadSecondViewControllerByTypeName ()
		{
			var vc = typeof(SecondViewController).LoadFromStoryboard ();
			Assert.IsNotNull (vc, "Type load from storyboard failed");
			if (null != vc)
				vc.Dispose ();
		}
	}
}
