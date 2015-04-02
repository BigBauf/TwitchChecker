namespace TwitchSharp.Model
{
	internal class TwitchStream
	{
		public long _id { get; set; }

		public string game { get; set; }

		public int viewers { get; set; }

		public string created_at { get; set; }

		public PreviewImgUrl preview { get; set; }

		public Channel channel { get; set; }
	}
}