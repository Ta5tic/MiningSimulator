using UnityEngine;
using System.Collections;

public class makeInvisible : MonoBehaviour {

    public GameObject invis;
	
	
	// Update is called once per frame
	void Update () 
    {
	    invis.renderer.enabled = false;
	}
}
