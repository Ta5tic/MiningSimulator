using UnityEngine;
using System.Collections;

public class IsEmpty : MonoBehaviour 
{
    public GameObject[] panel;

    public bool isEmpty = true;
	
	// Update is called once per frame
	void Update () 
    {
        if (isEmpty == true)
        {
            for (int i = 0; i < 7; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                panel[i].renderer.enabled = true;
            }
        }
        else if (isEmpty == false)
        {
            for (int i = 0; i < 7; i++)
            {
                /// If something is selected then do not render these objects.
                panel[i].renderer.enabled = false;
            }
        }
	}
}
