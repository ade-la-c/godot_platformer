using Godot;
using System;
using System.Xml.Schema;

public partial class LevelMenu : Control {

	[Export] PackedScene[] levels;
	public LevelButtonContainer levelButtonContainer;
	private int currentLevelIndex = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		levelButtonContainer = GetNode<LevelButtonContainer>("VBoxContainer/LevelButtonContainer");

		for (int i = 0; i < levels.Length; i++) {
			levels[i].ResourceName = "LEVEL " + (i+1);
			levelButtonContainer.GenerateLevelButton(levels[i], i);
		}

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	public void Next(string name) {

		currentLevelIndex += 1;
		GetTree().ChangeSceneToPacked(levels[currentLevelIndex]);
	}


	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
	}
}
