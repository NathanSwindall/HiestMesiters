using Godot;
using System;

public class TemplateCharacter : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	public const int SPEED = 10; 
	public const int MAX_SPEED = 100; 
	public const double FRICTION = 0.1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public int Speed { get {return SPEED; } }
	public int MaxSpeed { get {return MAX_SPEED;}}
	public  double Friction { get { return FRICTION;}}

 

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
