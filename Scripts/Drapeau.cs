using Godot;
using System;

public class Drapeau : Area2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	static public int numDrapeau = 0;
	public int idDrapeau;

    PressKey pressKey;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		numDrapeau++;
		idDrapeau = numDrapeau;
        pressKey = GetNode<PressKey>("PressKey");
	}

	public void _on_Drapeau_body_entered(object body)
	{
		if (body is mouvementBonhomme)
		{
            pressKey.AfficheScene();
			GD.Print("Drapeau touché");
		}
	}

	public void _on_Drapeau_body_exited(object body)
	{
		if (body is mouvementBonhomme)
		{
			pressKey.CacheScene();
			GD.Print("Drapeau quitté");
		}
	}




//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
