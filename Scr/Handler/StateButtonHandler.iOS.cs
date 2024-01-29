using KbrKiras.Maui.StateButton.Platform;

namespace KbrKiras.Maui.StateButton.Handler;
public partial class StateButtonHandler
{
	protected override CustomContentView CreatePlatformView()
	{
		base.CreatePlatformView();

		return new CustomContentView(VirtualView);
	}
}