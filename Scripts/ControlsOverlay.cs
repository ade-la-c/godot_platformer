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
			GetNode<HBoxContainer>("Control/VBoxContainer/PlayerSwapperContainer").Visible = false;
		} else {

			if (DisplayServer.IsTouchscreenAvailable() == false) {
				GetNode<Button>("Control/VBoxContainer/PlayerSwapperContainer/SwapButton").Visible = false;
			} else {
				GetNode<Label>("Control/VBoxContainer/PlayerSwapperContainer/SwapLabel").Visible = false;
			}
		}

		if (DisplayServer.IsTouchscreenAvailable() == false) {
			GetNode<HBoxContainer>("Control/VBoxContainer/MovementLabel").Visible = true;
			GetNode<HBoxContainer>("Control/VBoxContainer/JumptLabel").Visible = true;
		} else {
			GetNode<Label>("Control/VBoxContainer/MovementLabel").Visible = false;
			GetNode<Label>("Control/VBoxContainer/JumpLabel").Visible = false;
		}
	}


	//* signals
	private void _on_swap_button_pressed() {
		EmitSignal(SignalName.SwapPlayer);
	}

}
