using Godot;
using System;

public partial class PlayerSwapper : Node {

	[Export] public PlayerController[] players;
	int activePlayerIndex = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsKeyPressed(Key.Key1)) {activePlayerIndex = 0;}
		else if (Input.IsKeyPressed(Key.Key2)) {activePlayerIndex = 1;}
		else if (Input.IsKeyPressed(Key.Key3)) {activePlayerIndex = 2;}

		SwapPlayer();
	}

	 void SwapPlayer() {

		foreach (PlayerController player in players) {
			player.isActive = false;
			player.camera.Enabled = false;
		}

		players[activePlayerIndex].isActive = true;
		players[activePlayerIndex].camera.Enabled = true;
	}

	public PlayerController GetActivePlayer()
	{ return players[activePlayerIndex]; }
}
