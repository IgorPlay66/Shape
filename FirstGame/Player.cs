using Godot;
using System;

public class Player : KinematicBody2D
{
    public const int speed = 100;
    public const int gravity = 980;
    public const int power = -125;
    public AnimatedSprite Anim;
	public override void _Ready()
	{
        Anim = (AnimatedSprite)GetNode("AnimatedSprite");
        
    }

    public override void _PhysicsProcess(float delta)
    {
        var v = new Vector2();
       
        v.x = Input.GetActionStrength("right")*speed - Input.GetActionStrength("left")*speed;

        v.y = gravity * delta;
        MoveAndSlide(v);
        if (Input.IsActionPressed("space"))
        {
            Anim.Play("up");
            v.y = power;
            
        }

    }
    
}
