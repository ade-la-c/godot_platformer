using Godot;
using System;

public partial class PlayerSwapper : Node {

	[Export] public PlayerController[] players;
	public int activePlayerIndex = 0;
	int numberOfPlayers = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		numberOfPlayers = players.Length;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		SwapPlayer();
	}

	 void SwapPlayer() {


		if (Input.IsKeyPressed(Key.Key1)) {activePlayerIndex = 0;}
		else if (Input.IsKeyPressed(Key.Key2)) {activePlayerIndex = 1;}
		else if (Input.IsKeyPressed(Key.Key3)) {activePlayerIndex = 2;}
		else if (Input.IsKeyPressed(Key.Key4)) {activePlayerIndex = 3;}
		else if (Input.IsKeyPressed(Key.Key5)) {activePlayerIndex = 4;}
		else if (Input.IsKeyPressed(Key.Key6)) {activePlayerIndex = 5;}
		else if (Input.IsKeyPressed(Key.Key7)) {activePlayerIndex = 6;}
		else if (Input.IsKeyPressed(Key.Key8)) {activePlayerIndex = 7;}
		else if (Input.IsKeyPressed(Key.Key9)) {activePlayerIndex = 8;}

		if (activePlayerIndex >= numberOfPlayers) {activePlayerIndex = numberOfPlayers - 1;}

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
