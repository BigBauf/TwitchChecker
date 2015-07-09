using Newtonsoft.Json;
using System;
using System.IO;
using TwitchSharp.Model;

namespace TwitchSharp.Factories
{
	internal static class ModelFactory
	{
		public static Channel GetChannel(string p_json)
		{
			JsonSerializer s = new JsonSerializer();
			s.NullValueHandling = NullValueHandling.Ignore;
			if (!String.IsNullOrWhiteSpace(p_json))
				return s.Deserialize<Channel>(new JsonTextReader(new StringReader(p_json)));
			else
				return null;
		}

		public static StreamResult GetStreamResult(string p_json)
		{
			JsonSerializer s = new JsonSerializer();
			s.NullValueHandling = NullValueHandling.Ignore;
			if (!String.IsNullOrWhiteSpace(p_json))
				return s.Deserialize<StreamResult>(new JsonTextReader(new StringReader(p_json)));
			else
				return null;
		}

		public static SearchResult GetSearchResult(string p_json)
		{
			JsonSerializer s = new JsonSerializer();
			s.NullValueHandling = NullValueHandling.Ignore;
			if (!String.IsNullOrWhiteSpace(p_json))
				return s.Deserialize<SearchResult>(new JsonTextReader(new StringReader(p_json)));
			else
				return null;
		}

		public static FollowResult GetFollowResult(string p_json)
		{
			JsonSerializer s = new JsonSerializer();
			s.NullValueHandling = NullValueHandling.Ignore;
			if (!String.IsNullOrWhiteSpace(p_json))
				return s.Deserialize<FollowResult>(new JsonTextReader(new StringReader(p_json)));
			else
				return null;
		}
	}
}