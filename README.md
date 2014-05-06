MvvmStory.Touch
==

# This is in development a nuget package should be ready soon.

This is a MvvmCross plugin to auto load views from storyboards.
  This includes a ```[StoryBoard]``` attribute for marking ViewControllers and
    linking the storyboard name and id
      ```[Storybard(Name="Main", Id = "MainView")]``` .

Install
==

```powershell
Nuget Install
```

Add the following to the Setup.cs file in the app's Touch project:

```csharp
public class Setup : MvxTouchSetup
{
  ...
  protected override IMvxTouchViewsContainer CreateTouchViewsContainer ()
  {
    return new StoryBoardMvxTouchViewsContainer ();
  }
  ...
}
```
