using System.Collections.Generic;

namespace TwitchSharp.Model
{
	internal class SearchResult
	{
		public int _total { get; set; }

		public List<Channel> channels { get; set; }
	}
}