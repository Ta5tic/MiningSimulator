using UnityEngine;
using System.Collections;

public class TruckSelection : MonoBehaviour
{
    public GameObject[] mySelect;
    public GameObject[] compare;
    public int arrSize = 0;

    void Start()
    {
        // Depending on the number of objects the array size is 
        // subject to change.
        mySelect = new GameObject[arrSize];
        compare = new GameObject[10];

        for (int a = 0; a < 11; a++)
        {
            compare[a] = GetComponent<StoredGUIObjects>().objSelect[a];
            if (compare == null)
            {
                Debug.Log("Object was empty");
            }
        }
    }

    void Update()
    {
        for (int b = 0; b < 11; b++)
        {
            if (compare[b].tag == "Trucks")
            {
                mySelect[b].renderer.enabled = true;
            }
            else
            {
                mySelect[b].renderer.enabled = false;
            }
        }
    }
}
