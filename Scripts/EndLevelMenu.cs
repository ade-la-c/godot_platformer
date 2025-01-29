using Godot;
using System;

public partial class EndLevelMenu : Control {

	public string levelPath;
	public string nextLevelPath;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	//* signals
	private void _on_retry_button_pressed() {
		GetTree().ChangeSceneToFile(levelPath);
	}
	private void _on_next_button_pressed() {
		GetTree().ChangeSceneToFile(nextLevelPath);
	}
	private void _on_quit_button_pressed() {
		GetTree().ChangeSceneToFile("res://Scenes/UI/MainMenu.tscn");
	}
}
