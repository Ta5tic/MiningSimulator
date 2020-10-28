using UnityEngine;
using System.Collections;

public class pit1Reserve : MonoBehaviour {

	public Quaternion p;
	public Vector3[] tPath1;
	float y = 0;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(10);
		tPath1 = iTweenPath.GetPath ("pit2toReserve3");
		Debug.Log (tPath1);		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Spline.MoveOnPath (tPath1, transform.position, ref y,ref p, 15f, 100, EasingType.Cubic, true, true);
		transform.rotation = p;
	}
}
