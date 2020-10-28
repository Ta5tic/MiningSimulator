using UnityEngine;
using System.Collections;

public class truckDisp : MonoBehaviour 
{
    public GameObject[] truckPanel;

    public GameObject[] singleTags;

    public GameObject truck001;
    public GameObject truck002;

    public bool truckEmpty;
    public bool bigDisplay = false;

    // Update is called once per frame
    void Update()
    {
        truckEmpty = GetComponent<PSDIselectBoxes>().truckInput;
        //Debug.Log(truckEmpty);
        if (truckEmpty == true)
        {
            for (int i = 0; i < 6; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                truckPanel[i].renderer.enabled = true;
                singleTags[i].renderer.enabled = true;
            }

            if (GetComponent<PSDIselectBoxes>().truckNumber.ToString().Equals("Truck1"))
            {
                truck001.renderer.enabled = false;
            } 
            else
                truck001.renderer.enabled = true;
      
            if (GetComponent<PSDIselectBoxes>().truckNumber.ToString().Equals("Truck2"))
            {
                truck002.renderer.enabled = false;
            }
            else
                truck002.renderer.enabled = true;
        }
        else if (truckEmpty == false)
        {
            for (int i = 0; i < 6; i++)
            {
                /// If something isn't selected then do not render these objects.
                truckPanel[i].renderer.enabled = false;
                singleTags[i].renderer.enabled = false;
            }
        }       
    }
}
