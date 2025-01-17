using Godot;
using System;

public partial class LevelSwapper : Node {


	[Export] private LevelController[] levels;
	private int levelIndex = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
			GD.Print("levelswapper ready");//!debug
			GD.Print(levels[0]);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.G)) {
			GetTree().ChangeSceneToFile("res://Scenes/Levels/Level02.tscn");
		}
	}

}
