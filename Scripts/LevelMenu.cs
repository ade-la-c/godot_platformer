using Godot;
using System;
using System.Xml.Schema;

public partial class LevelMenu : Control {

	public LevelController[] levels;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		GD.Print(GetTree().Root.GetNode<LevelSwapper>("Main/Levels"));//!debug

		levels = GetTree().Root.GetNode<LevelSwapper>("Main/Levels").levels;

		// GD.Print("lvlswapper",GetTree().Root.GetNode<LevelSwapper>("Main/Levels"));//!debug

		GenerateLevelButtons();

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	public void GenerateLevelButtons() {

		var levelButtons = GetNode<VBoxContainer>("VBoxContainer/LevelButtons");
		var scene = GD.Load<PackedScene>("res://Scenes/UI/LevelButton.tscn");
		foreach (LevelController level in levels) {
			var instance = scene.Instantiate();
			levelButtons.AddChild(instance);
		}
	}

	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/Menu.tscn");
	}
}
