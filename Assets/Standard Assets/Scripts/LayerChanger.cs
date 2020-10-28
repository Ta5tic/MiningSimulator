using UnityEngine;
using System.Collections;

public class LayerChanger : MonoBehaviour 
{
    void Update()
    {
        /// Load Layer 1
        if (Input.GetKeyDown("f1"))
        {
            Application.LoadLevel("Test002");
        }
        /// Load Layer 2
        if(Input.GetKeyDown("f2"))
        {
            Application.LoadLevel("Test002_Layer2");
        }

        /// Load Layer 3
        if (Input.GetKeyDown("f3"))
        {
             Application.LoadLevel("Test002_Layer3");
        }
    }

}
