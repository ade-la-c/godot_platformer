using Godot;
using System;

public partial class LevelController : Node2D {

	public PlayerController[] players;
	public bool levelComplete = false;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		players = GetNode<PlayerSwapper>("Players").players;

		foreach (PlayerController player in players) {
			player.isOnExit = false;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.R)) {
			ResetLevel();
		}
		if (Input.IsKeyPressed(Key.Escape)) {
			GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
		}

		ExitCheck();
	}

	private void ResetLevel() {

		foreach (PlayerController player in players) {
			player.ResetPosition();
		}
	}

	private void ExitCheck() {

		if (players.Length == 0) return;

		foreach (PlayerController player in players) {
			if (player.isOnExit == false) return;
		}
		levelComplete = true;
		GD.Print("level success !!!!!");//!TMP
		//> go to EndLevelMenu
		//> lock player movement
	}
}
