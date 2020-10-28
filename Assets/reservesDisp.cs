using UnityEngine;
using System.Collections;

public class reservesDisp : MonoBehaviour
{
    public GameObject[] reservesPanel;

    public GameObject[] singleTagsReserves;

    // Properties of Reserves
    public GameObject[] ReserveID;
    public GameObject ReserveType;

    public bool reservesEmpty;

    void Update()
    {
        reservesEmpty = GameObject.Find("Objects").GetComponent<Spin>().spinReserves;

        if (reservesEmpty == true)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                reservesPanel[i].renderer.enabled = true;
                singleTagsReserves[i].renderer.enabled = true;
            }
            reservesPanel[6].renderer.enabled = true;

            ReserveType.renderer.enabled = true;

            for (int z = 0; z < 5; z++)
            {
                if (GetComponent<ObjectSelection>().Selections[z] != null)
                {
                    numberComparer(GetComponent<ObjectSelection>().Selections[z]);
                }
            }
        }
        else if (reservesEmpty == false)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If something isn't selected then do not render these objects.
                reservesPanel[i].renderer.enabled = false;
                singleTagsReserves[i].renderer.enabled = false;
            }
            reservesPanel[6].renderer.enabled = false;

            ReserveType.renderer.enabled = false;

            for (int j = 0; j < 3; j++)
            {
                ReserveID[j].renderer.enabled = false;
            }
        }
    }

    void numberComparer(GameObject obj)
    {        
        if (obj.transform.GetChild(0).ToString().Equals("Reserve1 (UnityEngine.Transform)"))
        {
            ReserveID[0].renderer.enabled = true;
        }
        /*if (obj.transform.GetChild(1).ToString().Equals("Reserve2 (UnityEngine.Transform)"))
        {
            ReserveID[1].renderer.enabled = true;
        }
        if (obj.transform.GetChild(2).ToString().Equals("Reserve3 (UnityEngine.Transform)"))
        {
            ReserveID[2].renderer.enabled = true;
        }*/
    }
}
