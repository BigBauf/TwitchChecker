namespace TwitchSharp.Model
{
	internal class Channel
	{
		public ChannelLinks _links { get; set; }

		public object background { get; set; }

		public string banner { get; set; }

		public string display_name { get; set; }

		public string game { get; set; }

		public string logo { get; set; }

		public bool? mature { get; set; }

		public string status { get; set; }

		public bool partner { get; set; }

		public string url { get; set; }

		public string video_banner { get; set; }

		public int _id { get; set; }

		public string name { get; set; }

		public string created_at { get; set; }

		public string updated_at { get; set; }

		public object abuse_reported { get; set; }

		public int delay { get; set; }

		public int followers { get; set; }

		public object profile_banner { get; set; }

		public object profile_banner_background_color { get; set; }

		public int views { get; set; }

		public string language { get; set; }
	}
}