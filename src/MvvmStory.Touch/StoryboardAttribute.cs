using System;
using System.Linq;

namespace MvvmStory.Touch
{
	[AttributeUsage(AttributeTargets.Class)]
	public class StoryboardAttribute : Attribute
	{
		public string Name { get; set; }
		public string Id { get; set; }

		public StoryboardAttribute(string name) : this()
		{
			this.Name = name;
		}

		public StoryboardAttribute()
		{
		}

		public static StoryboardAttribute Find(Type type)
		{
			return type.GetCustomAttributes (typeof(StoryboardAttribute), false)
				.OfType<StoryboardAttribute> ()
				.SingleOrDefault ();
		}
	}
}

