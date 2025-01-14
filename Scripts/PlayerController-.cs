using Godot;
using System;

/*
public partial class PlayerController_ : CharacterBody2D {

	public bool isActive = false;
	[Export] public float speed = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta) {
		
		// if (isActive) {
			MoveAndSlide();
		// }
	}

	void Movement(double delta) {

		float horizontal = Input.GetAxis("ui_left", "ui_right");
		Vector2 offset;

		offset = new Vector2((float)(delta * horizontal * speed), (float)0);
		Transform.Translated(offset);
	}

	void Jump() {

	}
}
// */