using UnityEngine;
using System.Collections;

public class Ipathing : MonoBehaviour 
{
	public Quaternion q;
	public Vector3[] tpath1;
	public Vector3[] tpath2;
	public Vector3[] tpath3;
	//public string myObj;
    public int time = 60;
	public int pathcount = 0;
	public int rotcount = 0;
	float t = 0;
	void Start () 
	{
		//var truck1 = GameObject.FindGameObjectsWithTag("Truck001");
		//myObj = gameObject.GetComponent<iTweenPath> ().pathName;
		tpath1 = iTweenPath.GetPath ("pit1crusherPath1");
		tpath2 = iTweenPath.GetPath ("truck1Path2");
		tpath3 = iTweenPath.GetPath ("truck1Path3");
		//Debug.Log (myObj);
		Debug.Log (tpath1);
		//Vector3[] path1 = new Vector3[3];
		//path1 [0] = new Vector3 (0f, 0f, 10f);
		//path1 [1] = new Vector3 (0f, 0f, 300f);
		//path1 [2] = new Vector3 (200f, 0f, 300f);
		//truckPath ();
		//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truckPath"),"orienttopath", true, "lookahead", 0.001f,"easytype", iTween.EaseType.linear, "time", time, "onupdate","myUpdateFunction","looptype",iTween.LoopType.loop));

		//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truck1Path1"), "orienttopath", true, "lookahead", 1f, "axis", "y", "time", time));
		//iTween.PutOnPath(gameObject, iTweenPath.GetPath ("truck1Path2"), 0);
		//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truck1Path2"), "orienttopath", true, "lookahead", 1f, "axis", "y", "time", time));
		//iTween.RotateTo(gameObject, iTween.Hash("rotation","x", 0, "y", -90, "z", 0,"easetype", iTween.EaseType.easeInOutSine, "time", .9f));


	}

	public void truckPath()
	{

		//iTween.RotateTo(gameObject, iTween.Hash("rotation","x", 0, "y", -90, "z", 0,"easetype", iTween.EaseType.easeInOutSine, "time", .9f));

		if (pathcount == 0) 
		{
			transform.position = Spline.MoveOnPath (tpath1, transform.position, ref t, 20f);
			transform.Rotate(0,-90,0);
			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truckPath"),"orienttopath", true, "lookahead", 0.001f, "axis", "y","easytype", "linear", "time", time, "oncomplete", "truckPath", "oncompletetarget", gameObject));
			//iTween.MoveTo (gameObject, iTween.Hash("path", iTweenPath.GetPath ("truck1Path1"), "orienttopath", true, "lookahead", 0.001f,"easytype", "linear", "speed", time, "oncomplete", "truckPath", "oncompletetarget", gameObject)); // this works
			pathcount++;
		}
		else if(pathcount == 1)
		{
			//iTween.PutOnPath(gameObject, iTweenPath.GetPath ("truck1Path2"), 0);
			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truckBackPath"),"orienttopath", true, "lookahead", 0.01f, "axis", "y","easytype", iTween.EaseType.linear, "time", time, "oncomplete", "truckPath", "oncompletetarget", gameObject));
			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truck1Path2"), "orienttopath", true, "lookahead", 0f, "axis", "y","easytype", iTween.EaseType.linear, "speed", time, "oncomplete", "truckPath", "oncompletetarget", gameObject));
			pathcount++;
		}
		else if(pathcount == 2)
		{
			//iTween.PutOnPath(gameObject, iTweenPath.GetPath ("truck1Path3"), 0);
			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("truck1Path3"), "orienttopath", true, "lookahead", 0f, "axis", "y","easytype", iTween.EaseType.linear, "speed", time));
			pathcount++;
		}
	}

	public void letsRotate()
	{
		if (rotcount == 0 && pathcount == 0) 
		{
			transform.Rotate(0,-90,0);
			rotcount++;
		}

	}

	void Update()
	{

			transform.position = Spline.MoveOnPath (tpath1, transform.position, ref t,ref q, 15f, 100, EasingType.Cubic, true, true);
			transform.rotation = q;
	}
}
