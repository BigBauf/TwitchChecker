using System.Collections.Generic;

namespace TwitchSharp.Model
{
	internal class FollowResult
	{
		public List<Follow> follows { get; set; }

		public int _total { get; set; }
	}
}