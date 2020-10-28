using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour 
{
    public Camera Layer1_Controller;
    public Camera Layer2_Controller;
    public Camera Layer3_Controller;

    public GameObject MainCamera;

    public Texture2D myCursor;

    public Transform target;

    int cursorSizeX = 16;
    int cursorSizeY = 16;

    void Awake()
    {
        Layer1_Controller.active = true;
        Layer1_Controller.camera.active = true;
    }

    void Start()
    {
        Screen.lockCursor = true;
        Screen.showCursor = true;
        MainCamera.active = true;
        //Layer1_Controller.active = true;
    }

    void Update () 
    {/// Load Layer 1 Camera
        if ((Input.GetKeyDown("f1")) || (Input.GetButton("LayerONE")))
        {
            Layer1_Controller.camera.active = true;
            Layer2_Controller.camera.active = false;
            Layer3_Controller.camera.active = false;
        }
        /// Load Layer 2 Camera
        if ((Input.GetKeyDown("f2")) || (Input.GetButton("LayerTWO")))
        {
            Layer1_Controller.camera.active = false;
            Layer2_Controller.camera.active = true;
            Layer3_Controller.camera.active = false;
        }

        /// Load Layer 3 Camera
        if ((Input.GetKeyDown("f3")) || (Input.GetButton("LayerTHREE")))
        {
            Layer1_Controller.camera.active = false;
            Layer2_Controller.camera.active = false;
            Layer3_Controller.camera.active = true;
            
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x - cursorSizeX / 2 + cursorSizeX / 2,
            (Screen.height - Input.mousePosition.y) - cursorSizeY / 2 + cursorSizeY / 2,
            cursorSizeX, cursorSizeY), myCursor);
    }
}
