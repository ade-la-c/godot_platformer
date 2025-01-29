using Godot;
using System;

public partial class LevelButton : Button {

	public PackedScene level;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		Text = level.ResourceName;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

    public override void _Pressed() {


		GetTree().ChangeSceneToPacked(level);
	}
}
