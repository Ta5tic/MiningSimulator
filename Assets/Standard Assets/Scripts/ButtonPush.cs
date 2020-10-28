using UnityEngine;
using System.Collections;

public class ButtonPush : MonoBehaviour 
{
    public GameObject upButton;
    public GameObject downButton;
    public GameObject upButtonSpeed;
    public GameObject downButtonSpeed;

    public bool upScale;
    public bool downScale;
    public bool upSpeedScale;
    public bool downSpeedScale;

	void Start () 
    {
        upScale = false;
        downScale = false;
        upSpeedScale = false;
        downSpeedScale = false;
	}
	
	void Update () 
    {
        greenButtonPushed();
        redButtonPushed();        
	}

    void greenButtonPushed()
    {
        // If 'P' is pushed then push the green button..
        if ((Input.GetKeyDown("p")) || (Input.GetButton("UpScenario")))
        {
            upButton.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            upScale = true;
            
        }
        if ((Input.GetKeyUp("p")) || (Input.GetButtonUp("UpScenario")))
        {
            upButton.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            upScale = false;
        }
        // If 'I' is pushed then push the green speed button..
        if ((Input.GetKeyDown("i")) || (Input.GetAxis("UpSpeed") > 0))
        {
            if (Input.GetKeyDown("i"))
            {
                upButtonSpeed.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            }
            upSpeedScale = true;

        }
        if ((Input.GetKeyUp("i"))  || (Input.GetAxis("UpSpeed") == 0))
        {
            if (Input.GetKeyUp("i"))
            {
                upButtonSpeed.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            }
            upSpeedScale = false;
        }
    }

    void redButtonPushed()
    {
        // If 'O' is pushed then push the green button..
        if ((Input.GetKeyDown("o")) || (Input.GetButton("DownScenario")))
        {
            downButton.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            downScale = true;
        }
        if ((Input.GetKeyUp("o")) || (Input.GetButtonUp("DownScenario")))
        {
            downButton.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            downScale = false;
        }
        // If 'U' is pushed then push the green button..
        if ((Input.GetKeyDown("u")) || (Input.GetAxis("DownSpeed") > 0))
        {
            if (Input.GetKeyDown("u"))
            {
                downButtonSpeed.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            }
            downSpeedScale = true;
        }
        if ((Input.GetKeyUp("u")) || (Input.GetAxis("DownSpeed") == 0))
        {
            if (Input.GetKeyDown("u"))
            {
                downButtonSpeed.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            }
            downSpeedScale = false;
        }
    }
}
