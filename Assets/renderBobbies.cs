using UnityEngine;
using System.Collections;

public class rednerBobbies : MonoBehaviour 
{
    public bool on;

    public GameObject[] bobbiePiles;

    void Start()
    {
        bobbiePiles = new GameObject[4];
    }

	// Update is called once per frame
	void Update () 
    {
        on = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().twentyFive;
        if (on == true)
        {
            for (int i = 0; i <= 4; i++)
            {
                bobbiePiles[i].active = true;
            }
        }
        else if (on == false)
        {
            for (int i = 0; i <= 4; i++)
            {
                bobbiePiles[i].active = false;
            }
        }

	}
}
