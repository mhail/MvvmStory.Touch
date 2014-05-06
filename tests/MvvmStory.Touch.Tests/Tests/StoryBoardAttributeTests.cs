using System;
using NUnit.Framework;
using MonoTouch.UIKit;

namespace MvvmStory.Touch.Tests
{
	[TestFixture]
	public class StoryBoardAttributeTests
	{
		[Test]
		public void TestNamePropertyIsUpdatedByCostructor ()
		{
			var attribute = new MvvmStory.Touch.StoryboardAttribute ("Foo");
			Assert.AreEqual ("Foo", attribute.Name);
		}

		[Test]
		public void TestAttributeCanFindInstanceOnType ()
		{
			var attribute = MvvmStory.Touch.StoryboardAttribute.Find (typeof(DummyStoryBoardViewController));
			Assert.IsNotNull (attribute);
		}

		[Storyboard]
		public class DummyStoryBoardViewController : UIViewController
		{

		}

	}
}
