using UnityEngine;
using System.Collections;

public class wasteTruck : MonoBehaviour {
	
	public Vector3[] start;
	public Vector3[] end;
	public Quaternion p;
	public Vector3[] path;
    public float speed;
	float y = 0;
	// Use this for initialization
	void Start () {
		start = new Vector3[1];
		start [0] = new Vector3 (3150, 20, -2300);
		end = new Vector3[1];
		end [0] = new Vector3 (3225, 20, -2300);
		path = iTweenPath.GetPath ("wastepath");
		transform.position = start[0];
		//Debug.Log (path);
	}
	
	// Update is called once per frame
	void Update () 
    {
        speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;
		if(gameObject.transform.position != end[0])
		{
			transform.position = Spline.MoveOnPath (path, transform.position, 
                                                    ref y,ref p, speed, 100, EasingType.Cubic, true, true);
			transform.rotation = p;
		}
		if(end[0] == gameObject.transform.position)
		{
			y = 0;
			transform.position = start[0];
		}
	}
}
