using Godot;
using System;

public partial class LevelController : Node2D {

	[Export] private PlayerController[] players;
	public bool levelComplete = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.R)) {
			ResetLevel();
		}
		// if (Input.IsKeyPressed(Key.Escape)) {
		// 	GetTree().Quit();
		// }	//todo		coming up with main menu

	}

	private void ResetLevel() {

		foreach (PlayerController player in players) {
			player.ResetPosition();
		}
	}
}
