using Godot;
using System;


public class player : KinematicBody2D
{
    //exported x and y

    [Export]

    public int moveSpeed = 250;

    public override void _PhysicsProcess(float delta){
        // basic player
        Vector2 motion = new Vector2();
        // remember that y is negative
        motion.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
        motion.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");
        // move the amount of movespace multiplied by delta of frame time
        MoveAndCollide(motion.Normalized() * moveSpeed  * delta);
    }
 


}

