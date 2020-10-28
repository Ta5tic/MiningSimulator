using UnityEngine;
using System.Collections;

public class reactivePath : MonoBehaviour
{

    public Vector3[] start;
    public Vector3[] end;
    public Quaternion p;
    public Vector3[] path;
    float y = 0;
    public float speed;

    void Start()
    {
        start = new Vector3[1];
        start[0] = new Vector3(900, 20, 1790);
        end = new Vector3[1];
        end[0] = new Vector3(825, 20, 1800);
        path = iTweenPath.GetPath("pit1crusherPath1");
        transform.position = start[0];
    }

    void Update()
    {
        speed = GameObject.Find("Switches").GetComponent<ScenarioBehaviour>().truckSpeed;                 
        
        if (gameObject.transform.position != end[0])
        {
            transform.position = Spline.MoveOnPath(path, transform.position, ref y, ref p, speed, 100, EasingType.Cubic, true, true);
            transform.rotation = p;
        }
        if (end[0] == gameObject.transform.position)
        {
            y = 0;
            transform.position = start[0];
        }
    }
}