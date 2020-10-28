using UnityEngine;
using System.Collections;

public class render75Bobbies : MonoBehaviour
{
    public bool on;
    public int size = 5;

    public GameObject[] bobbiePiles;
    public TextMesh percent;
    public TextMesh profit;

    double seventyFiveProfit;

    // Update is called once per frame
    void Update()
    {
        on = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().seventyFive;
        //Debug.Log(on);
        seventyFiveProfit = GameObject.Find("Runner").GetComponent<ScenarioManager>().run4.netRevenue;


        if (on == true)
        {
            for (int i = 0; i < size; i++)
            {
                //Debug.Log(bobbiePiles[i]);
                bobbiePiles[i].active = true;
                percent.renderer.enabled = true;
                profit.text = seventyFiveProfit.ToString();
                profit.renderer.enabled = true;
            }
        }
        else if (on == false)
        {
            for (int i = 0; i < size; i++)
            {
                bobbiePiles[i].active = false;
                percent.renderer.enabled = false;
                profit.renderer.enabled = false;
            }
        }

    }
}
