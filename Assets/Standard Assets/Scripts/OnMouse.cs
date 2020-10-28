using UnityEngine;
using System.Collections;

public class OnMouse : MonoBehaviour 
{
	private Color startcolor;
	public bool MouseOnObject = false;

	void OnMouseEnter()
	{
		startcolor = renderer.material.color;
		renderer.material.color = Color.yellow;
		MouseOnObject = true;
	}

	void OnMouseExit()
	{
		renderer.material.color = startcolor;
		MouseOnObject = false;
	}

}
