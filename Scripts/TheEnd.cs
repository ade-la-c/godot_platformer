using Godot;
using System;

public partial class TheEnd : Control {


	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.Escape) || Input.IsKeyPressed(Key.Enter) || Input.IsActionPressed("quit")) {
			GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
		}
	}
}
