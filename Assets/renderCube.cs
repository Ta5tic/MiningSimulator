using UnityEngine;
using System.Collections;

public class renderCube : MonoBehaviour 
{
    public bool on;
    public int size = 3;

    public GameObject[] bobbiePiles;

	// Update is called once per frame
	void Update () 
    {
        on = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().fifty;
        Debug.Log(on);
        if (on == true)
        {
            for (int i = 0; i < size; i++)
            {
                Debug.Log(bobbiePiles[i]);
                bobbiePiles[i].active = true;
            }
        }
        else if (on == false)
        {
            for (int i = 0; i < size; i++)
            {
                bobbiePiles[i].active = false;
            }
        }

	}
}
