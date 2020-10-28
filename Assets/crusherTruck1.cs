using UnityEngine;
using System.Collections;

public class crusherTruck1 : MonoBehaviour {

	public Quaternion p;
	public Vector3[] tpathTwo1;
	float y = 0;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(10);
		tpathTwo1 = iTweenPath.GetPath ("track2Path1");
		Debug.Log (tpathTwo1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Spline.MoveOnPath (tpathTwo1, transform.position, ref y,ref p, 15f, 100, EasingType.Cubic, true, true);
		transform.rotation = p;
	}
}
