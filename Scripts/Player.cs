using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private Vector2 syncPos = new Vector2(0,0);

	public override void _Ready(){
		GetNode<MultiplayerSynchronizer>("MultiplayerSynchronizer").SetMultiplayerAuthority(int.Parse(Name));
	}
	public override void _PhysicsProcess(double delta)
	{
		if (GetNode<MultiplayerSynchronizer>("MultiplayerSynchronizer").GetMultiplayerAuthority() == Multiplayer.GetUniqueId())
        {
            if (Input.IsActionPressed("MoveUp"))
            {
                Godot.Vector2 currentPosition = Position;
                currentPosition.Y -= 5;
                Position = currentPosition;
            }
            if (Input.IsActionPressed("MoveDown"))
            {
                Godot.Vector2 currentPosition = Position;
                currentPosition.Y += 5;
                Position = currentPosition;
            }
            syncPos = GlobalPosition;
        }
        else
        {
            GlobalPosition = GlobalPosition.Lerp(syncPos, .5f);
        }
	}
}
