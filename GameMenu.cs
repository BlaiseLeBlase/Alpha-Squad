using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour 
{


	void start()
	{

	}

	void Update ()
	{
	
	}

	void OnGUI ()
	{
		if (pause) 
		{
			GUI.depth = numDepth;
			GUI.skin = mainUI;
			GUI.Box(new Rect(0,0, Screen.width, Screen.height), "", GUI.Skin.GetStyle("BackgroundMenu"));

			GUI.BeginGroup(new Rect((Screen.width = 150) / 2, (Screen.height = 150) / 2, 150, 150));

			GUI.Label(new Rect(25, 30, 100, 30), "Pause", GUI.skin.label);
			if (GUI.Button(new Rect(0, 50, 150, 30), "Continue"))
			    {
					pause = false;
				}

		}

	
	}
}
