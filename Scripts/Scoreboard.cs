using Godot;
using System;

public partial class Scoreboard : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnPlayer1GoalBodyEntered(CharacterBody2D body)
	{
		if (body.Name == "Ball")
		{
			Label Player1Score = (Label)GetNode("Player1Score");
			int score = Int32.Parse(Player1Score.Text);
			score++;
			Player1Score.Text = score.ToString();			
		}
	}

	public void OnPlayer2GoalBodyEntered(CharacterBody2D body)
	{
		if (body.Name == "Ball")
		{
			Label Player2Score = (Label)GetNode("Player2Score");
			int score = Int32.Parse(Player2Score.Text);
			score++;
			Player2Score.Text = score.ToString();
		}
	}
}
