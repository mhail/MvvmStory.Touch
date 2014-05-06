using System;
using Cirrious.MvvmCross.Touch.Views;

namespace MvvmStory.Touch
{
	public class StoryBoardMvxTouchViewsContainer : MvxTouchViewsContainer
	{
		protected override IMvxTouchView CreateViewOfType (Type viewType, Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
		{
			return (viewType.LoadFromStoryboard() as IMvxTouchView) ?? base.CreateViewOfType (viewType, request);
		}
	}
}

