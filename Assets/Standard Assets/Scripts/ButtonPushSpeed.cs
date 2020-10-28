using UnityEngine;
using System.Collections;

public class ButtonPushSpeed : MonoBehaviour
{
    public GameObject upButton2;
    public GameObject downButton2;

    public bool upScale2;
    public bool downScale2;

    public char buttonUp2;
    public char buttonDown2;

    // Use this for initialization
    void Start()
    {
        upScale2 = false;
        downScale2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        greenButtonPushed2();
        redButtonPushed2();
        /*if (Input.GetMouseButtonDown(1))
        {
            RaycastHit selector = new RaycastHit();
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out selector))
            {
                Debug.Log("here......");
                Debug.Log(selector.transform.gameObject.tag);
                if (selector.transform.gameObject.tag == "GreenButton")
                {
                    upButton.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
                }
            }
        }*/

    }

    void greenButtonPushed2()
    {
        // If 'P' is pushed then push the green button..
        if (Input.GetKeyDown("i"))
        {
            upButton2.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            upScale2 = true;

        }
        if (Input.GetKeyUp("i"))
        {
            upButton2.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            upScale2 = false;
        }
    }

    void redButtonPushed2()
    {
        // If 'O' is pushed then push the green button..
        if (Input.GetKeyDown("i"))
        {
            downButton2.transform.Translate(new Vector3(0.0f, -60.0f, 0.0f));
            downScale2 = true;
        }
        if (Input.GetKeyUp("i"))
        {
            downButton2.transform.Translate(new Vector3(0.0f, 60.0f, 0.0f));
            downScale2 = false;
        }
    }
}
