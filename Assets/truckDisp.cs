using UnityEngine;
using System.Collections;

public class truckDisp : MonoBehaviour 
{
    public GameObject[] truckPanel;

    public GameObject[] singleTagTrucks;

    // Properties of each Truck
    public GameObject TruckCapacity;
    public GameObject[] TruckNumber;
    public GameObject[] TruckRoute;
    public GameObject TruckType;

    public GameObject[] numberCompare;

    public bool truckEmpty;

    void Update()
    {

        for (int a = 0; a < 5; a++)
        {
            truckEmpty = GameObject.Find("Objects").GetComponent<Spin>().spinTruck;

            if (truckEmpty == true)
            {
                for (int i = 0; i <= 5; i++)
                {
                    /// If nothing is selected in the PSDI and layer 2 is selected 
                    /// then render blank boxes.
                    truckPanel[i].renderer.enabled = true;
                    singleTagTrucks[i].renderer.enabled = true;
                }
                truckPanel[6].renderer.enabled = true;

                // Render Truck Capacity
                TruckCapacity.renderer.enabled = true;
                // Render Truck Type
                TruckType.renderer.enabled = true;
                for (int z = 0; z < 5; z++)
                {
                    if (GetComponent<ObjectSelection>().Selections[z] != null)
                    {
                        numberComparer(GetComponent<ObjectSelection>().Selections[z]);                       
                    }
                }

            }
            else if (truckEmpty == false)
            {
                for (int i = 0; i <= 5; i++)
                {
                    /// If something is selected then do not render these objects.
                    truckPanel[i].renderer.enabled = false;
                    singleTagTrucks[i].renderer.enabled = false;
                }
                truckPanel[6].renderer.enabled = false;

                TruckCapacity.renderer.enabled = false;
                TruckType.renderer.enabled = false;
                for (int b = 0; b < 8; b++)
                {
                    TruckNumber[b].renderer.enabled = false;
                }
            }
        }
        
    }

    void numberComparer(GameObject obj)
    {
        if (obj.ToString().Equals("Truck1 (UnityEngine.GameObject)"))
        {
            TruckNumber[0].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck2 (UnityEngine.GameObject)"))
        {
            TruckNumber[1].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck3 (UnityEngine.GameObject)"))
        {
            TruckNumber[2].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck4 (UnityEngine.GameObject)"))
        {
            TruckNumber[3].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck5 (UnityEngine.GameObject)"))
        {
            TruckNumber[4].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck6 (UnityEngine.GameObject)"))
        {
            TruckNumber[5].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck7 (UnityEngine.GameObject)"))
        {
            TruckNumber[6].renderer.enabled = true;
        }
        if (obj.ToString().Equals("Truck8 (UnityEngine.GameObject)"))
        {
            TruckNumber[7].renderer.enabled = true;
        }
    }
}
