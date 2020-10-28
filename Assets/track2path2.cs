using UnityEngine;
using System.Collections;

public class track2path2 : MonoBehaviour {
			
		public Vector3[] start2;
		public Vector3[] end2;
		public Quaternion p;
		public Vector3[] tpathTwo2;
        public float speed;
		float y = 0;

		void Start () {
			start2 = new Vector3[1];
			start2 [0] = new Vector3 (950, 20, -3750);
			end2 = new Vector3[1];
			end2 [0] = new Vector3 (825, 20,-3700);
			tpathTwo2 = iTweenPath.GetPath ("track2Path2");
			transform.position = start2[0];
		}
		
		void Update () 
        {
            speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;
		if(gameObject.transform.position != end2[0])
		{
			transform.position = Spline.MoveOnPath (tpathTwo2, transform.position,
                                                    ref y,ref p, speed, 100, 
                                                    EasingType.Cubic, true, true);
			transform.rotation = p;
		}
		if(end2[0] == gameObject.transform.position)
		{
			y = 0;
			transform.position = start2[0];
		}
	}
}
