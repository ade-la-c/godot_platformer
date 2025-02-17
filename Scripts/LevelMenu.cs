using Godot;
using System;
using System.Xml.Schema;

public partial class LevelMenu : Control {

	[Export] PackedScene[] levels;
	public LevelButtonContainer levelButtonContainer;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		levelButtonContainer = GetNode<LevelButtonContainer>("VBoxContainer/LevelButtonContainer");

		for (int i = 0; i < levels.Length; i++) {
			levels[i].ResourceName = "LEVEL " + (i+1);
			levelButtonContainer.GenerateLevelButton(levels[i]);
		}

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}


	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
	}
}
