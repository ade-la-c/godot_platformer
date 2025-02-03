using Godot;
using System;

public partial class ControlsOverlay : CanvasLayer {


	[Signal] public delegate void SwapPlayerEventHandler();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}


	//* signals
	private void _on_swap_button_pressed() {
		EmitSignal(SignalName.SwapPlayer);
	}

}
