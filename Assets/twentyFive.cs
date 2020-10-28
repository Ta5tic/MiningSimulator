using UnityEngine;
using System.Collections;

public class twentyFive : MonoBehaviour
{
    public bool scenarioGo;
    public GameObject[] twentyFiveTrucks;

    // Update is called once per frame
    void Update()
    {
        scenarioGo = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().twentyFive;

        if (scenarioGo == true)
        //if(GetComponent<ScenarioBehaviour>().seventyFive == true)
        {
            // Display all the trucks
            for (int i = 0; i <= 8; i++)
            {
                twentyFiveTrucks[i].active = true;
            }
        }
        else if (scenarioGo == false)
        {
            // Hide all the trucks
            for (int i = 0; i <= 8; i++)
            {
                twentyFiveTrucks[i].active = false;
            }
        }
    }
}
