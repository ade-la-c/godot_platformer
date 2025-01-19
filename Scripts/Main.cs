using Godot;
using System;

public partial class Main : Node2D {

	public LevelController[] levels;
	public int numberOfLevels;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		levels = GetNode<LevelSwapper>("Levels").levels;

		numberOfLevels = levels.Length;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		GetTree().ChangeSceneToFile("res://Scenes/UI/Menu.tscn");
	}
}
