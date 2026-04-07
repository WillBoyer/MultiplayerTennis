using Godot;
using System;
using System.Security.Principal;

public partial class Paddle : Area2D
{
	[Export]
	public int Speed { get; set; } = 400;

	public Vector2 ScreenSize { get; set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var velocity = Vector2.Zero;

        if (Input.IsActionPressed("MoveDown"))
        {
            velocity.Y += 1;
        }

        if (Input.IsActionPressed("MoveUp"))
        {
            velocity.Y -= 1;
        }

        Position += velocity * Speed * (float)delta;
        Position = new Vector2(
            x: Mathf.Clamp(Position.X, 0, ScreenSize.X),
            y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y)
        );
	}
}
