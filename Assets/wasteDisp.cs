using UnityEngine;
using System.Collections;

public class wasteDisp : MonoBehaviour
{
    public GameObject[] wastesPanel;

    public GameObject[] singleTagsWastes;

    public GameObject WasteID;
    public GameObject WasteType;

    public bool wastesEmpty;

    // Update is called once per frame
    void Update()
    {
        wastesEmpty = GameObject.Find("Objects").GetComponent<Spin>().spinWastes;

        if (wastesEmpty == true)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If nothing is selected in the PSDI and layer 2 is selected 
                /// then render blank boxes.
                wastesPanel[i].renderer.enabled = true;
                singleTagsWastes[i].renderer.enabled = true;
            }
            wastesPanel[6].renderer.enabled = true;

            WasteID.renderer.enabled = true;
            WasteType.renderer.enabled = true;
        }
        else if (wastesEmpty == false)
        {
            for (int i = 0; i <= 5; i++)
            {
                /// If something isn't selected then do not render these objects.
                wastesPanel[i].renderer.enabled = false;
                singleTagsWastes[i].renderer.enabled = false;              
            }
            wastesPanel[6].renderer.enabled = false;

            WasteID.renderer.enabled = false;
            WasteType.renderer.enabled = false;
        }
    }
}
