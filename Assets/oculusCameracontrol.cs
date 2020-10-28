using UnityEngine;
using System.Collections;

public class oculusCameracontrol : MonoBehaviour
{
    public GameObject L1;
    public Camera Left;
    public Camera Right;

    public Texture2D myCursor;

    public Transform target;

    Vector3 onePosition;
    Vector3 twoPosition;
    Vector3 threePosition;

    void Start()
    {
        Screen.lockCursor = true;
        Screen.showCursor = true;

        // Inside the Environment
        onePosition = new Vector3(331.6f, 200.5f, 225.3f);
        // Outside the Environment
        twoPosition = new Vector3(-3279.75f, 2415.0f, -427.1304f);
        // Inside the IQube
        threePosition = new Vector3(850f, 260f, -00f);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("b")) || (Input.GetButton("LayerONE")))
        {
            L1.transform.position = onePosition;
            // Culling = 5000
            Left.farClipPlane = 5000;
            Right.farClipPlane = 5000;
        }
        if ((Input.GetKeyDown("n")) || (Input.GetButton("LayerTWO")))
        {
           L1.transform.position = twoPosition;
            // Culling = 25000
           Left.farClipPlane = 25000;
           Right.farClipPlane = 25000;
        }
        if ((Input.GetKeyDown("m")) || (Input.GetButton("LayerTHREE")))
        {
            L1.transform.position = threePosition;
            // Culling = 3500
            Left.farClipPlane = 3500;
            Right.farClipPlane = 3500;
        }
    }
}
