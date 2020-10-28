using UnityEngine;
using System.Collections;

public class scenarioSwitcher : MonoBehaviour 
{
    public int zeroInt;
    public int twentyFiveInt;
    public int fiftyInt;
    public int seventyFiveInt;
    public int hundredInt;
    
    void start()
    {
        zeroInt = 0;
        twentyFiveInt = 1;
        fiftyInt = 2;
        seventyFiveInt = 3;
        hundredInt = 4;
    }
    
    // Update is called once per frame
	void Update () 
    {
        if (GetComponent<ScenarioBehaviour>().change == 0)
        {
            Debug.Log("0 scene enabled");
        }
        else if (GetComponent<ScenarioBehaviour>().change == 1)
        {
            Debug.Log("25 scene enabled");
        }
        else if (GetComponent<ScenarioBehaviour>().change == 2)
        {
            Debug.Log("50 scene enabled");
        }
        else if (GetComponent<ScenarioBehaviour>().change == 3)
        {
            Debug.Log("75 scene enabled");
        }
        else if (GetComponent<ScenarioBehaviour>().change == 4)
        {
            Debug.Log("100 scene enabled");
        }
	}
}
