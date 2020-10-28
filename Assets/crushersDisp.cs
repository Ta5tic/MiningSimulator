using UnityEngine;
using System.Collections;

public class crushersDisp : MonoBehaviour
{
    public GameObject[] crushersPanel;

    public GameObject[] singleTagsCrushers;

    // Properties of the crusher
    public GameObject CrusherCost;
    public GameObject[] CrusherID;
    public GameObject CrusherLoad;
    public GameObject CrusherNumber;
    public GameObject CrusherRate;

    public bool crushersEmpty;

    // Update is called once per frame
    void Update()
    {
        crushersEmpty = GameObject.Find("Objects").GetComponent<Spin>().spinCrusher;

        if (crushersEmpty == true)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                crushersPanel[i].renderer.enabled = true;
                singleTagsCrushers[i].renderer.enabled = true;
            }
            crushersPanel[6].renderer.enabled = true;

            CrusherCost.renderer.enabled = true;
            CrusherLoad.renderer.enabled = true;
            CrusherNumber.renderer.enabled = true;
            CrusherRate.renderer.enabled = true;

            for (int z = 0; z < 5; z++)
            {
                if (GetComponent<ObjectSelection>().Selections[z] != null)
                {
                    numberComparer(GetComponent<ObjectSelection>().Selections[z]);
                }
            }
        }
        else if (crushersEmpty == false)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If something isn't selected then do not render these objects.
                crushersPanel[i].renderer.enabled = false;
                singleTagsCrushers[i].renderer.enabled = false;
            }
            crushersPanel[6].renderer.enabled = false;

            CrusherCost.renderer.enabled = false;
            CrusherLoad.renderer.enabled = false;
            CrusherNumber.renderer.enabled = false;
            CrusherRate.renderer.enabled = false;

            for (int j = 0; j < 5; j++)
            {
                CrusherID[j].renderer.enabled = false;
            }
        }
    }

    void numberComparer(GameObject obj)
    {
        if (obj.transform.GetChild(0).ToString().Equals("Crusher1 (UnityEngine.Transform)"))
        {
            CrusherID[0].renderer.enabled = true;
        }
        /*if (obj.transform.GetChild(0).ToString().Equals("Crusher2 (UnityEngine.Transform)"))
        {
            CrusherID[1].renderer.enabled = true;
        }
        if (obj.transform.GetChild(0).ToString().Equals("Crusher3 (UnityEngine.Transform)"))
        {
            CrusherID[2].renderer.enabled = true;
        }
        if (obj.transform.GetChild(0).ToString().Equals("Crusher4 (UnityEngine.Transform)"))
        {
            CrusherID[3].renderer.enabled = true;
        }
        if (obj.transform.GetChild(0).ToString().Equals("Crusher5 (UnityEngine.Transform)"))
        {
            CrusherID[4].renderer.enabled = true;*/
        //}
    }
}
