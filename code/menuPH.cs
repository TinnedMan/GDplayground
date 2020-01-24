using Godot;
using System;

public class menuPH : Control
{
     public override void _Ready()
    {
        //
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

 private void _on_NewGame_pressed()
    {
     GD.Print("play button clicked");
     GetTree().ChangeScene("res://Scenes/Maintest.tscn");
    }
}
       