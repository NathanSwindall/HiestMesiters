using Godot;
using HesitMeistersCSharp.Utils;
using System;

public class Player : TemplateCharacter
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	public Vector2 motion = new Vector2();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta)
	{
		this.updateMovement();
		this.MoveAndSlide(this.motion);
	}

	public void updateMovement()
	{
		// Make it so your player is always looking at the mouse 
		this.LookAt(this.GetGlobalMousePosition());
		// Y direction
		if (Input.IsActionPressed(Constants.MOVEDOWN))
		{
			this.motion.y = Mathf.Clamp(this.motion.y + Constants.SPEED, 0, Constants.MAX_SPEED );
			GD.Print(this.motion.y);
		}
		else if (Input.IsActionPressed(Constants.MOVEUP)) 
		{
			this.motion.y = Mathf.Clamp(this.motion.y - Constants.SPEED,  -Constants.MAX_SPEED , 0);
			GD.Print(this.motion.y);
		}
		else
		{
			motion.y = Mathf.Lerp(motion.y, 0, Constants.FRICTION);
		}

		// X direction
		if (Input.IsActionPressed(Constants.MOVELEFT))
		{
			this.motion.x = Mathf.Clamp(motion.x - Constants.SPEED, -Constants.MAX_SPEED, 0 );
			GD.Print(this.motion.x);
		}
		else if (Input.IsActionPressed(Constants.MOVERIGHT))
		{
			this.motion.x = Mathf.Clamp(motion.x + Constants.SPEED,0, Constants.MAX_SPEED );
			GD.Print(this.motion.x);
		}
		else 
		{
			motion.x = Mathf.Lerp(motion.x, 0, Constants.FRICTION);
		}
	}
  

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
