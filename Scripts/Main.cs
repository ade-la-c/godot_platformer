using Godot;
using System;

public partial class Main : Node2D {

	public LevelController[] levels;
	private bool shouldChangeScene = true;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		levels = GetNode<LevelSwapper>("Levels").levels;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.A)) GD.Print("a pressed");//!debug
		if (shouldChangeScene) {
			shouldChangeScene = false;
			GetTree().ChangeSceneToFile("res://Scenes/UI/Menu.tscn");
		}
	}
}
