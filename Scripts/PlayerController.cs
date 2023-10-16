using Godot;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

public partial class PlayerController : CharacterBody2D
{
	[Export] public float speed = 300.0f;
	[Export] public float jumpVelocity = -400.0f;
	public bool isActive = false;
	[Export] public Camera2D camera;
	Vector2 initialPosition;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _Ready() {

		initialPosition = Position;
	}

	public override void _Process(double delta) {

		if (isActive) {
			camera.MakeCurrent();
		} else {
			// camera. = false;
		}
	}

	public override void _PhysicsProcess(double delta) {

		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		if (isActive) {

			// Handle Jump.
			if (Input.IsActionJustPressed("jump") && IsOnFloor())
				velocity.Y = jumpVelocity;

			// Get the input direction and handle the movement/deceleration.
			float direction = Input.GetAxis("move_left", "move_right");
			if (direction != 0) {

				velocity.X = direction * speed;
			} else {

				velocity.X = Mathf.MoveToward(Velocity.X, 0, speed);
			}

		}
		Velocity = velocity;
		MoveAndSlide();
	}

	public void ResetPosition() {

		Position = initialPosition;
	}
}
