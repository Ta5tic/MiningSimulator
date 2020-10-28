using UnityEngine;
using System.Collections;

public class render100Bobbies : MonoBehaviour
{
    public bool on;
    public int size = 4;

    public GameObject[] bobbiePiles;
    public TextMesh percent;
    public TextMesh profit;

    double hundredProfit;

    // Update is called once per frame
    void Update()
    {
        on = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().hundred;

        hundredProfit = GameObject.Find("Runner").GetComponent<ScenarioManager>().run5.netRevenue;


        if (on == true)
        {
            for (int i = 0; i < size; i++)
            {
                //Debug.Log(bobbiePiles[i]);
                bobbiePiles[i].active = true;
                percent.renderer.enabled = true;
                profit.text = hundredProfit.ToString();
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
