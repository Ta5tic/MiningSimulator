using UnityEngine;
using System.Collections;

public class seventyFive : MonoBehaviour 
{
    public bool scenarioGo;
    public GameObject[] seventyFiveTrucks;
    
    // Update is called once per frame
	void Update () 
    {
        scenarioGo = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().seventyFive;

        if (scenarioGo == true)
        //if(GetComponent<ScenarioBehaviour>().seventyFive == true)
        {
            // Display all the trucks
            for (int i = 0; i <= 8; i++)
            {
                seventyFiveTrucks[i].active = true;
            }
        }
        else if (scenarioGo == false)
        {
            // Hide all the trucks
            for (int i = 0; i <= 8; i++)
            {
                seventyFiveTrucks[i].active = false;
            }
        }
	}
}
