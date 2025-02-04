using Godot;
using System;

public partial class ControlsOverlay : CanvasLayer {

	[Signal] public delegate void SwapPlayerEventHandler();
	public bool swapper;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (swapper == false) {
			GetNode<HBoxContainer>("Control/PlayerSwapperContainer").Visible = false;
		} else {

			if (DisplayServer.IsTouchscreenAvailable() == false) {
				GetNode<Button>("Control/PlayerSwapperContainer/SwapButton").Visible = false;
			} else {
				GetNode<Label>("Control/PlayerSwapperContainer/Label").Visible = false;
			}
		}
	}


	//* signals
	private void _on_swap_button_pressed() {
		EmitSignal(SignalName.SwapPlayer);
	}

}
