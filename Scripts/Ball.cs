using Godot;
using System;

public partial class Ball : CharacterBody2D
{
    private Godot.Vector2 syncPos = new Godot.Vector2(0,0);

    KinematicCollision2D collisionData;

    public override void _Ready()
    {
        Position = new Vector2(512, 256);
        Velocity = new Vector2(300, 0);
    }

    public override void _PhysicsProcess(double delta)
    {
        collisionData = MoveAndCollide(Velocity * new Vector2((float)delta, (float)delta));
        if (collisionData != null)
        {
            RandomNumberGenerator r = new RandomNumberGenerator();
            Vector2 tempVelocity = Velocity;
            tempVelocity.Y += r.RandfRange(-20, 20);
            Velocity = tempVelocity;

            Velocity = Velocity.Bounce(collisionData.GetNormal());
        }
    }

    public void OnPlayer1GoalBodyEntered(CharacterBody2D body)
    {
        Position = new Vector2(512, 256);
        Velocity = new Vector2(300, 0);
    }

    public void OnPlayer2GoalBodyEntered(CharacterBody2D body)
    {
        Position = new Vector2(512, 256);
        Velocity = new Vector2(300, 0);
    }
}