using UnityEngine;
using System.Collections;

public class PSDIselectBoxes : MonoBehaviour 
{
    public bool empty = true;

    public bool crushersInput = false;
    public bool pitInput = false;
    public bool reservesInput = false;
    public bool wastesInput = false;
    public bool truckInput = false;

    public GameObject truckNumber;
    public GameObject pitNumber;
    public GameObject reservesNumber;
    public GameObject crushersNumber;
    public GameObject wastesNumber;

    private int k = 0;

    void Update() 
    {
        if (GetComponent<ObjectSelection>().Selections[k] != null)
        {
            Selected(GetComponent<ObjectSelection>().Selections[k]);
            if (k <= 3)
                k++;
        }
	}

    void Selected(GameObject obj)
    {
        // Check to see if it's a truck..
        if (obj.transform.gameObject.tag == "Trucks")
        {
            truckInput = true;
            truckNumber = obj.transform.gameObject;          
        }

        // Check to see if it's a pit..
        if (obj.transform.gameObject.tag == "Pits")
        {
            pitInput = true;
            pitNumber = obj.transform.gameObject;
        }

        // Check to see if it's a reserve..
        if (obj.transform.gameObject.tag == "Reserves")
        {
            reservesInput = true;
            reservesNumber = obj.transform.gameObject;
        }

        // Check to see if it's a crusher..
        if (obj.transform.gameObject.tag == "Crushers")
        {
            crushersInput = true;
            crushersNumber = obj.transform.gameObject;
        }

        // Check to see if it's a waste reserve..
        if (obj.transform.gameObject.tag == "Wastes")
        {
            wastesInput = true;
            wastesNumber = obj.transform.gameObject;
        }

    }
}
