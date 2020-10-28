﻿using UnityEngine;
using System.Collections;

public class pit2toReserve3 : MonoBehaviour {

	public Vector3[] start;
	public Vector3[] end;
	public Quaternion p;
	public Vector3[] path;
    public float speed;
	float y = 0;
	// Use this for initialization
	void Start () {
		start = new Vector3[1];
		start [0] = new Vector3 (1850, 20, 1750);
		end = new Vector3[1];
		end [0] = new Vector3 (1775, 20, 1800);
		path = iTweenPath.GetPath ("pit2toReserve3");
		transform.position = start[0];
		//Debug.Log (path);
	}
	
	// Update is called once per frame
	void Update () 
    {
   
            speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;
            if (gameObject.transform.position != end[0])
            {
                transform.position = Spline.MoveOnPath(path, transform.position,
                                                        ref y, ref p, speed, 100,
                                                        EasingType.Cubic, true, true);
                transform.rotation = p;
            }
            if (end[0] == gameObject.transform.position)
            {
                y = 0;
                transform.position = start[0];
            }
        
	}
}
