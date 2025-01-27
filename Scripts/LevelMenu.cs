using Godot;
using System;
using System.Xml.Schema;

public partial class LevelMenu : Control {

	[Export] PackedScene[] levels;
	public VBoxContainer levelButtonContainer;
	private int currentLevelIndex = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		GenerateLevelButtons();

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
		levelButtonContainer = GetNode<VBoxContainer>("VBoxContainer/LevelButtons");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	public void GenerateLevelButtons() {

		// TODO generate buttons based on levels array

		for (int i = levels.Length; i > 0; i--) {
			var scene = GD.Load<PackedScene>("res://Scenes/UI/LevelButton.tscn");
			var inst = scene.Instantiate<Button>();
			levelButtonContainer.AddChild(inst);
			// AddChild(inst);
		}
	}

	public void Next() {

		currentLevelIndex += 1;
		GetTree().ChangeSceneToPacked(levels[currentLevelIndex]);
	}


	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
	}
}
