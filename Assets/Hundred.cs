using UnityEngine;
using System.Collections;

public class Hundred : MonoBehaviour
{
    public bool scenarioGo;
    public GameObject[] hundredTrucks;

    // Update is called once per frame
    void Update()
    {
        scenarioGo = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().hundred;

        if (scenarioGo == true)
        //if(GetComponent<ScenarioBehaviour>().seventyFive == true)
        {
            // Display all the trucks
            for (int i = 0; i <= 8; i++)
            {
                hundredTrucks[i].active = true;
            }
        }
        else if (scenarioGo == false)
        {
            // Hide all the trucks
            for (int i = 0; i <= 8; i++)
            {
                hundredTrucks[i].active = false;
            }
        }
    }
}
