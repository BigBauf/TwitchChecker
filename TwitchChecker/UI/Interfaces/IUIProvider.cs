namespace TwitchChecker.UI.Interfaces
{
	public interface IUIProvider
	{
		void SetView(UiView p_views);

		void Init(IController controller);
	}
}