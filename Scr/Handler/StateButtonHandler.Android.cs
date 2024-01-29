using KbrKiras.Maui.StateButton.Platform;

namespace KbrKiras.Maui.StateButton.Handler;
public partial class StateButtonHandler
{
	protected override CustomContentViewGroup CreatePlatformView()
	{
		base.CreatePlatformView();

		return new CustomContentViewGroup(Context, VirtualView);
	}
}