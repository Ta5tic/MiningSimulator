using UnityEngine;
using System.Collections;

public class Fifty : MonoBehaviour
{
    public bool scenarioGo;
    public GameObject[] fiftyTrucks;

    // Update is called once per frame
    void Update()
    {
        scenarioGo = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().fifty;

        if (scenarioGo == true)
        //if(GetComponent<ScenarioBehaviour>().seventyFive == true)
        {
            // Display all the trucks
            for (int i = 0; i <= 8; i++)
            {
                fiftyTrucks[i].active = true;
            }
        }
        else if (scenarioGo == false)
        {
            // Hide all the trucks
            for (int i = 0; i <= 8; i++)
            {
                fiftyTrucks[i].active = false;
            }
        }
    }
}
