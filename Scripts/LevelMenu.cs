using Godot;
using System;

public partial class LevelMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		GetNode<Button>("VBoxContainer/BackButton").GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	//*signals
	private void _on_back_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/UI/Menu.tscn");
	}
}
