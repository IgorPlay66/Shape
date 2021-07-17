using Godot;
using System;

public class move : KinematicBody2D
{
    [Export] public int speed = 200;
    [Export] public int gravitation = 100;
    public Vector2 velocity = new Vector2();

   
    
    
    
     


    public override void _PhysicsProcess(float delta)
    {
        velocity = new Vector2();

        if (Input.IsActionPressed("right"))
            velocity.x += 1;
        if (Input.IsActionPressed("left"))
            velocity.x -= 1;
        if (Input.IsActionPressed("up") & IsOnFloor())
            velocity.y -= 10000;
        if (IsOnFloor())
            gravitation = 0;
        if (!IsOnFloor())
            gravitation = 100;
        velocity.y += gravitation;  
        MoveAndSlide(velocity.Normalized() * speed , new Vector2(0, -1));
       
    }
        
    



}
