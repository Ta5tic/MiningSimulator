using UnityEngine;
using System.Collections;

public class pitsDisp : MonoBehaviour
{
    public GameObject[] pitsPanel;

    public GameObject[] singleTagsPits;

    // Properties of each Pit
    public GameObject[] PitNumber;
    public GameObject PitType;


    public bool pitEmpty;

    // Update is called once per frame
    void Update()
    {
        pitEmpty = GameObject.Find("Objects").GetComponent<Spin>().spinPit;

        if (pitEmpty == true)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                pitsPanel[i].renderer.enabled = true;
                singleTagsPits[i].renderer.enabled = true;
            }
            pitsPanel[6].renderer.enabled = true;

            // Render Pit Type
            PitType.renderer.enabled = true;

            for (int z = 0; z < 5; z++)
            {
                if (GetComponent<ObjectSelection>().Selections[z] != null)
                {
                    numberComparer(GetComponent<ObjectSelection>().Selections[z]);
                }
            }
        }
        else if (pitEmpty == false)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If something isn't selected then do not render these objects.
                pitsPanel[i].renderer.enabled = false;
                singleTagsPits[i].renderer.enabled = false;
            }
            pitsPanel[6].renderer.enabled = false;

            PitType.renderer.enabled = false;
            PitNumber[0].renderer.enabled = false;
            PitNumber[1].renderer.enabled = false;
        }
    }

    void numberComparer(GameObject obj)
    {       
        if (obj.transform.GetChild(0).ToString().Equals("Pit1 (UnityEngine.Transform)"))
        {
            PitNumber[0].renderer.enabled = true;
        }
        /*if (obj.transform.GetChild(0).ToString().Equals("Pit2 (UnityEngine.Transform)"))
        {
            PitNumber[1].renderer.enabled = true;
        } */     
    }
}
