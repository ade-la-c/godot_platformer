using Godot;
using System;

public partial class LevelButtonContainer : VBoxContainer {



	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}

	public void GenerateLevelButton(PackedScene level) {

	// TODO generate buttons based on levels array

		var scene = GD.Load<PackedScene>("res://Scenes/UI/LevelButton.tscn");
		var inst = scene.Instantiate<LevelButton>();
		inst.level = level;
		AddChild(inst);
	}
}
