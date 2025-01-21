using Godot;
using System;

public partial class Main : Node2D {

	public LevelController[] levels;
	public int numberOfLevels;
	private bool shouldChangeScene = true;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		levels = GetNode<LevelSwapper>("Levels").levels;
		numberOfLevels = levels.Length;
		GD.Print("numberoflevels main : ", numberOfLevels);//!debug

		GetNode<LevelMenu>("LevelMenu").numberOfLevels = numberOfLevels;
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
