using UnityEngine;
using System.Collections;

public class ObjectSelection : MonoBehaviour 
{
    // Truck Objects
    public bool oneTruck = true;

    // Pit Objects
    public bool onePit = true;

    // Waste Objects
    public bool oneWaste = true;

    // Reserves Objects
    public bool oneReserve = true;

    // Crusher Objects
    public bool oneCrusher = true;

    // Array to store the selections for the PSDI
    // also, a temporary arraySize
    public int arraySize = 5;
    public GameObject[] Selections;

    // Integer for cycling through the array
    private int i = 0;

    public bool[] deleted;
    public bool objectDeleted = false;

    // Used for object deletions
    private GameObject changer;

    void Start()
    {
        // Initialization of the Selections GameObject array  
        Selections = new GameObject[arraySize];
        deleted = new bool[arraySize];

        // Initialize the boolean array to all be true until deleted
        for (int b = 0; b < arraySize; b++)
        {
            deleted[b] = true;
        }
    }

    void Update() 
    {
        // Go through the list once to ensure that the array is being 
        // sorted properly..
        if (objectDeleted == true)
        {
            for (int j = 0; j < 4; j++)
            {
                if ((Selections[j] == null) && (Selections[j + 1] != null))
                {
                    // If the selection of the array is null but the position after
                    // has a selection then move it back down
                    changer = Selections[j + 1];
                    Selections[j] = changer;
                    Selections[j + 1] = null;

                    // Change the bool back to false to stop this loop
                    objectDeleted = false;
                }
                // Check if there is a gap in the storing of objects
                if (j < 3)
                {
                    if ((Selections[j] == null) && (Selections[j + 2] != null))
                    {
                        // If the selection of the array is null but the position after
                        // has a selection then move it back down
                        changer = Selections[j + 2];
                        Selections[j] = changer;
                        Selections[j + 2] = null;

                        // Change the bool back to false to stop this loop
                        objectDeleted = false;
                    }
                }
            }
            if ((i > 0) && (i < 4))
            {
                if (Selections[i] != null)
                {
                    i--;
                }
            }
        }

        // Right Click on the mouse
        // -- Used to remove entities from the PSDI array
        if ((Input.GetMouseButtonDown(1)) || (Input.GetButton("Deletion"))) 
        {
            RaycastHit delete = new RaycastHit();

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out delete))
            {
                for (int a = 0; a < 5; a++)
                {
                    if ((delete.transform.gameObject.tag == "Trucks") ||
                        (delete.transform.gameObject.tag == "Wastes") ||
                        (delete.transform.gameObject.tag == "Reserves") || 
                        (delete.transform.gameObject.tag == "Pits") ||
                        (delete.transform.gameObject.tag == "Crushers"))
                    {
                        GameObject childObject = delete.collider.gameObject;
                        
                        if(Selections[a] == childObject.transform.parent.gameObject)
                        {
                            if (Selections[a].tag.ToString() == "Trucks")
                            {
                                oneTruck = true;
                            }
                            if (Selections[a].tag.ToString() == "Wastes")
                            {
                                oneWaste = true;
                            }
                            if (Selections[a].tag.ToString() == "Reserves")
                            {
                                oneReserve = true;
                            }
                            if (Selections[a].tag.ToString() == "Pits")
                            {
                                onePit = true;
                            }
                            if (Selections[a].tag.ToString() == "Crushers")
                            {
                                oneCrusher = true;
                            }
                            
                            // Removing the object from the PSDI
                            Selections[a] = null;
                            // Changing a boolean to sort the array
                            objectDeleted = true;
                            deleted[a] = false;                           
                        }
                    }
                }
            }
        }

        // Left Click on the mouse
        //
        // OCULUS MODE
        //
        // -- Used to add entities from the PSDI array
        if ((Input.GetMouseButtonDown(0))|| (Input.GetButton("Selection")))
        {
            RaycastHit myRay;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out myRay))
            {
                Debug.DrawRay(transform.position, myRay.point, Color.green);

                // Sorting the array if there are deletions..
                if (i >= 1)
                {
                    if (Selections[i - 1] == null)
                    {
                        i--;
                    }
                }

                /// If the Trucks are selected then...
                if (myRay.transform.gameObject.tag == "Trucks")
                {
                    if (oneTruck == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObject = myRay.collider.gameObject;
                        // Store that truck childObject into the objectSelection array
                        Selections[i] = childObject.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one truck can be stored at a time
                        oneTruck = false;
                    }
                }

                /// If the Waste Reserves are selected then...
                if (myRay.transform.gameObject.tag == "Wastes")
                {
                    if (oneWaste == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectWastes = myRay.collider.gameObject;

                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectWastes.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one waste can be stored at a time
                        oneWaste = false;
                    }
                }

                /// If the Reserves are selected then...
                if (myRay.transform.gameObject.tag == "Reserves")
                {
                    if (oneReserve == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectReserves = myRay.collider.gameObject;


                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectReserves.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Reserves can be stored at a time
                        oneReserve = false;
                    }
                }

                /// If the Pits are selected then...
                if (myRay.transform.gameObject.tag == "Pits")
                {
                    if (onePit == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectPit = myRay.collider.gameObject;

                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectPit.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Pit can be stored at a time
                        onePit = false;
                    }
                }

                /// If the Crushers are selected then...
                if (myRay.transform.gameObject.tag == "Crushers")
                {
                    if (oneCrusher == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectCrusher = myRay.collider.gameObject;

                        // Turn the child object into a selection fo the parent GameObject
                        Selections[i] = childObjectCrusher.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Crusher can be stored at a time
                        oneCrusher = false;
                    }
                }
            }
        }

        // Left Click on the mouse
        //
        // NORMAL MODE
        //
        // -- Used to add entities from the PSDI array
        /*if ((Input.GetMouseButtonDown(0)) || (Input.GetButton("Selection")))
        {
            RaycastHit hit = new RaycastHit();

            Debug.DrawLine(transform.position, hit.point, Color.cyan);

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                // Sorting the array if there are deletions..
                if (i >= 1)
                {
                    if (Selections[i - 1] == null)
                    {
                        i--;
                    }
                }
                /// If the Trucks are selected then...
                if (hit.transform.gameObject.tag == "Trucks")
                {
                    if (oneTruck == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObject = hit.collider.gameObject;
                        // Store that truck childObject into the objectSelection array
                        Selections[i] = childObject.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one truck can be stored at a time
                        oneTruck = false;
                    }
                }

                /// If the Waste Reserves are selected then...
                if (hit.transform.gameObject.tag == "Wastes")
                {
                    if (oneWaste == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectWastes = hit.collider.gameObject;

                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectWastes.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one waste can be stored at a time
                        oneWaste = false;
                    }
                }

                /// If the Reserves are selected then...
                if (hit.transform.gameObject.tag == "Reserves")
                {
                    if (oneReserve == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectReserves = hit.collider.gameObject;


                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectReserves.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Reserves can be stored at a time
                        oneReserve = false;
                    }
                }

                /// If the Pits are selected then...
                if (hit.transform.gameObject.tag == "Pits")
                {
                    if (onePit == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectPit = hit.collider.gameObject;

                        // Turn the child object into a selection of the parent Game Object
                        Selections[i] = childObjectPit.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Pit can be stored at a time
                        onePit = false;
                    }
                }

                /// If the Crushers are selected then...
                if (hit.transform.gameObject.tag == "Crushers")
                {
                    if (oneCrusher == true)
                    {
                        // Create a new Game Object for the selection made by the raycast
                        GameObject childObjectCrusher = hit.collider.gameObject;

                        // Turn the child object into a selection fo the parent GameObject
                        Selections[i] = childObjectCrusher.transform.parent.gameObject;
                        deleted[i] = true;
                        i++;

                        // Make the boolean false so ONLY one Crusher can be stored at a time
                        oneCrusher = false;
                    }
                }
            }
        }*/
	}
}

