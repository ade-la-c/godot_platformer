using Godot;
using System;
using System.Xml.Schema;

public partial class LevelMenu : Control {

	[Export] public LevelController[] levels;
	private int currentLevelIndex;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		GenerateLevelButtons();

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	public void GenerateLevelButtons() {

		// TODO generate buttons based on levels array
	}

	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/Menu.tscn");
	}
}
