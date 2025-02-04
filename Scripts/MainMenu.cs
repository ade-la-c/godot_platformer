using Godot;
using System;

public partial class MainMenu : Control {

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		GetNode<Button>("VBoxContainer/StartButton").GrabFocus();
		if (DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Fullscreen) {
			GetNode<CheckButton>("Fullscreen").ButtonPressed = true;
		}
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
		GetTree().ChangeSceneToFile("res://Scenes/UI/LevelMenu.tscn");
	}
	public void _on_quit_button_pressed() {
		GetTree().Quit();
	}

	//* signals
	private void _on_fullscreen_toggled(bool button_pressed) {
		if (button_pressed == true) {
			DisplayServer.WindowSetMode(DisplayServer.WindowMode.Fullscreen);
		} else {
			DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
		}
	}
}
