using Godot;
using System;

public partial class LevelSwapper : Node {


	[Export] private LevelController[] levels;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
			GD.Print("levelswapper ready");//!debug
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

			GD.Print("ee");//!debug
		if (Input.IsKeyPressed(Key.G)) {
			GetTree().ChangeSceneToFile("res://Scenes/Levels/Level02.tscn");
		}
	}
}
