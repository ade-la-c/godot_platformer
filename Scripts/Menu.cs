using Godot;
using System;

public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		GetNode<Button>("VBoxContainer/StartButton").GrabFocus();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

		// if (Input.IsKeyPressed(Key.Escape)) {
		// 	GetTree().Quit();
		// }
	}

	//*signals
	private void _on_start_button_pressed() {

		GetTree().ChangeSceneToFile("res://Scenes/Levels/Level01.tscn");
	}
	private void _on_levels_button_pressed() {

	}
	private void _on_quit_button_pressed() {
		GetTree().Quit();
	}
}
