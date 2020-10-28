using UnityEngine;
using System.Collections;

public class track2path3 : MonoBehaviour {

	public Vector3[] start3;
	public Vector3[] end3;
	public Quaternion p;
	public Vector3[] tpathTwo3;
    public float speed;

    public bool crusherToReserve;

    public bool truckSelected;

	float y = 0;
	// Use this for initialization
	void Start () {
		start3 = new Vector3[1];
		start3 [0] = new Vector3 (-1000, 20, -4350);
		end3 = new Vector3[1];
		end3 [0] = new Vector3 (-1025, 20, -4425);
		tpathTwo3 = iTweenPath.GetPath ("track2Path3");
		transform.position = start3[0];
		//Debug.Log (tpathTwo3);
        crusherToReserve = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;
        if(gameObject.transform.position != end3[0])
		{
			transform.position = Spline.MoveOnPath (tpathTwo3, transform.position, 
                                                    ref y,ref p, speed, 100, 
                                                    EasingType.Cubic, true, true);
			transform.rotation = p;
		}
		if(end3[0] == gameObject.transform.position)
		{
			y = 0;
			transform.position = start3[0];
		}
	}
}
