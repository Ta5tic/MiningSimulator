using UnityEngine;
using System.Collections;

public class render0Bobbies : MonoBehaviour
{
    public bool on;
    public int size = 1;

    public GameObject[] bobbiePiles;
    public TextMesh percent;
    public TextMesh profit;

    double zeroProfit;

    // Update is called once per frame
    void Update()
    {
        on = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().zero;

        zeroProfit = GameObject.Find("Runner").GetComponent<ScenarioManager>().run1.netRevenue;

        if (on == true)
        {
            for (int i = 0; i < size; i++)
            {
                bobbiePiles[i].active = true;
                percent.renderer.enabled = true;
                profit.text = zeroProfit.ToString();
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
