using UnityEngine;
using System.Collections;

public class renderCubes : MonoBehaviour 
{

    public GameObject[] cubes;
	
	// Update is called once per frame
	void Update () 
    {
        for (int i = 0; i < 5; i++)
        {
            cubes[i].renderer.enabled = false;
        }
	}
}
