using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public GameObject spinningTruck;
    public GameObject spinningPit;
    public GameObject spinningReserves;
    public GameObject spinningWastes;
    public GameObject spinningCrusher;

    public bool spinTruck;
    public bool spinPit;
    public bool spinReserves;
    public bool spinWastes;
    public bool spinCrusher;

    public bool truckDisp;
    public bool pitDisp;
    public bool resDisp;
    public bool wasteDisp;
    public bool crushDisp;

    public GameObject[] spinObj;

    void Start()
    {
        Screen.fullScreen = true;
        spinningTruck.active = false;
        spinningPit.active = false;
        spinningReserves.active = false;
        spinningWastes.active = false;
        spinningCrusher.active = false;

        spinTruck = false;
        spinPit = false;
        spinReserves = false;
        spinWastes = false;
        spinCrusher = false;

        truckDisp = false;
        pitDisp = false;
        resDisp = false;
        wasteDisp = false;
        crushDisp = false;
    }
	
	void Update () 
    {
        normal();
        //oculus();
        
        // Check if the object is selected...
        for (int i = 0; i < 5; i++)
        {
            spinObj[i] = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().Selections[i];
            //spinObj[i] = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().Selections[i];

            if (spinObj[i] != null)
            {
                displayPSDI(i);               
            }          
        }
        removePSDI();      
	}

    void normal()
    {
        // Enabled for Normal
        truckDisp = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().oneTruck;
        pitDisp = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().onePit;
        resDisp = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().oneReserve;
        wasteDisp = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().oneWaste;
        crushDisp = GameObject.Find("NormalControls").GetComponent<ObjectSelection>().oneCrusher;
    }

    void oculus()
    {
        // Enabled for Oculus
        truckDisp = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().oneTruck;
        pitDisp = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().onePit;
        resDisp = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().oneReserve;
        wasteDisp = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().oneWaste;
        crushDisp = GameObject.Find("OculusControls").GetComponent<ObjectSelection>().oneCrusher;
        
    }

    void displayPSDI(int i)
    {
        if (spinObj[i].tag == "Trucks")
        {
            spinningTruck.active = true;
            spinningTruck.transform.Rotate(0, 1, 0);
            spinTruck = true;
        }

        if (spinObj[i].tag == "Pits")
        {
            spinningPit.active = true;
            spinningPit.transform.Rotate(0, 1, 0);
            spinPit = true;
        }

        if (spinObj[i].tag == "Wastes")
        {
            spinningWastes.active = true;
            spinningWastes.transform.Rotate(0, 1, 0);
            spinWastes = true;
        }
        if (spinObj[i].tag == "Reserves")
        {
            spinningReserves.active = true;
            spinningReserves.transform.Rotate(0, 1, 0);
            spinReserves = true;
        }
        if (spinObj[i].tag == "Crushers")
        {
            spinningCrusher.active = true;
            spinningCrusher.transform.Rotate(0, 1, 0);
            spinCrusher = true;
        }
    }

    void removePSDI()
    {
        if (truckDisp == true)
        {
            spinningTruck.active = false;
            spinTruck = false;
        }

        if (pitDisp == true)
        {
            spinningPit.active = false;
            spinPit = false;
        }

        if (wasteDisp == true)
        {
            spinningWastes.active = false;
            spinWastes = false;
        }

        if (crushDisp == true)
        {
            spinningCrusher.active = false;
            spinCrusher = false;
        }

        if (resDisp == true)
        {
            spinningReserves.active = false;
            spinReserves = false;
        }
    }
}
