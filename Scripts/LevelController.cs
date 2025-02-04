using Godot;
using System;
using System.Diagnostics;

public partial class LevelController : Node2D {

	public PlayerController[] players;
	[Export] public PackedScene nextLevel;
	public bool levelComplete = false;
	private EndLevelMenu inst;
	private PlayerSwapper playerSwapper;
	public ControlsOverlay controlsOverlay;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		playerSwapper = GetNode<PlayerSwapper>("Players");
		players = playerSwapper.players;

		controlsOverlay = GetNode<ControlsOverlay>("ControlsOverlay");

		foreach (PlayerController player in players) {
			player.isOnExit = false;
		}

		if (players.Length > 1) {
			controlsOverlay.swapper = true;
		} else {
			controlsOverlay.swapper = false;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		// if (Input.IsKeyPressed(Key.R)) {

		if (Input.IsKeyPressed(Key.Escape)) {
			GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
		}

		if (levelComplete == false)
			ExitCheck();

		if (Input.IsActionJustPressed("Reset")) {
			ResetLevel();
		}
	}

	private void ResetLevel() {

		levelComplete = false;
		if (inst != null)
			RemoveChild(inst);
		foreach (PlayerController player in players) {
			player.stopMovement = false;
			player.ResetPosition();
		}
	}

	private void ExitCheck() {

		if (players.Length == 0) return;

		foreach (PlayerController player in players) {
			if (player.isOnExit == false) return;
		}
		levelComplete = true;

		var endMenuScene = GD.Load<PackedScene>("res://Scenes/UI/EndLevelMenu.tscn");
		inst = endMenuScene.Instantiate<EndLevelMenu>();
		inst.levelPath = SceneFilePath;

		if (nextLevel == null) {
			inst.nextLevelPath = "res://Scenes/UI/MainMenu.tscn";
		} else {
			inst.nextLevelPath = nextLevel.ResourcePath;
		}

		AddChild(inst);

		foreach (PlayerController player in players) {
			player.stopMovement = true;
		}
	}
}
