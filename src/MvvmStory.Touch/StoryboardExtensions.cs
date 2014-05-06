using System;
using MonoTouch.UIKit;

namespace MvvmStory.Touch
{
	public static class StoryboardExtensions
	{
		public static UIViewController LoadFromStoryboard(this Type type)
		{
			var attribute = StoryboardAttribute.Find (type);

			if (null == attribute)
				return null;

			var storyboard = UIStoryboard.FromName (attribute.Name ?? type.Name, null);
			if (null == storyboard)
				return null;

			var viewController = (string.IsNullOrWhiteSpace (attribute.Id) ? storyboard.InstantiateInitialViewController () : storyboard.InstantiateViewController (attribute.Id)) as UIViewController;

			return viewController;
		}

		public static T LoadFromStoryboard<T>() where T : UIViewController
		{
			return typeof(T).LoadFromStoryboard () as T;
		}
	}
}

