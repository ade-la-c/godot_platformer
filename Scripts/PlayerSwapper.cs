using Godot;
using System;

public partial class PlayerSwapper : Node {

	[Export] public PlayerController[] players;
	public int activePlayerIndex = 0;
	int numberOfPlayers = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		numberOfPlayers = players.Length;
		players[0].isActive = true;
		players[activePlayerIndex].camera.Enabled = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		if (Input.IsActionJustPressed("tab"))
			SwapPlayer();
	}

	void SwapPlayer() {

		if (activePlayerIndex == numberOfPlayers - 1) {
			activePlayerIndex = 0;
		} else {
			activePlayerIndex += 1;
		}
		foreach (PlayerController player in players) {
			player.isActive = false;
			player.camera.Enabled = false;
		}
		players[activePlayerIndex].isActive = true;
		players[activePlayerIndex].camera.Enabled = true;
	}

	public PlayerController GetActivePlayer()
	{ return players[activePlayerIndex]; }


	//* signals
	private void _on_controls_overlay_swap_player() {

		SwapPlayer();
	}
}
