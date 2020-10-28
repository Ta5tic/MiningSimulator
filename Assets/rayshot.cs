using UnityEngine;
using System.Collections;

public class rayshot : MonoBehaviour 
{

    Ray pointOne;
    

    public GameObject cubeone;
    public GameObject forward;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {          
            RaycastHit myRay;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out myRay))
            {
                Debug.DrawRay(transform.position, myRay.point, Color.green);
                
                if (myRay.collider != null)
                {
                    
                }
            }

        }*/
    }

}/* pointOne = new Ray(cubeone.transform.position, forward.transform.position);
            pointOne = new Ray(cubeone.transform.position, forward.transform.position);
            Debug.DrawLine(cubeone.transform.position, forward.transform.position, Color.green);
            */
