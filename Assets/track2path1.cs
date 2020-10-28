using UnityEngine;
using System.Collections;

public class track2path1 : MonoBehaviour 
{
	public Vector3[] start;
	public Vector3[] end;
	public Quaternion p;
	public Vector3[] tpathTwo1;
    public float speed;
	float y = 0;
	float wy = 0;

	void Start () 
    {
		start = new Vector3[1];
		start [0] = new Vector3 (-250, 20, -3750);
		end = new Vector3[1];
		end [0] = new Vector3 (-350,20,-3700);
        //yield return new WaitForSeconds(10);
        tpathTwo1 = iTweenPath.GetPath ("track2Path1");
        transform.position = start[0];
    }

	void Update () 
    {
		speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;
		if(gameObject.transform.position != end[0])
		{
			transform.position = Spline.MoveOnPath (tpathTwo1, transform.position, 
                                                    ref y,ref p, speed, 100, 
                                                    EasingType.Cubic, true, true);
			transform.rotation = p;
		}
		if(end[0] == gameObject.transform.position)
		{
			y = 0;
			transform.position = start[0];
		}
	}
}
