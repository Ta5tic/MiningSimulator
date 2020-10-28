using UnityEngine;
using System.Collections;

namespace DataIO
{

    public class Grapher3 : MonoBehaviour
    {

        //[Range(10,30)]
        public int resolution = 50;
        private int currentResolution;

        public enum FunctionOption
        {
            Linear,
            Exponential
        }

        private delegate float FunctionDelegate(Vector3 p, float t);
        private static FunctionDelegate[] functionDelegates = 
		{
			Linear,
			Exponential
		};
        public FunctionOption function;


        private ParticleSystem.Particle[] points;
        // Use this for initialization
        void Start()
        {

            CreatePoints();
        }
        private void CreatePoints()
        {
            /*if (resolution < 10 || resolution > 100) 
            {
                Debug.LogWarning("Grapher resolution out of bounds, resetting to minimum.", this);
                resolution = 10;
            }*/
            currentResolution = resolution;
            points = new ParticleSystem.Particle[resolution * resolution * resolution];//3points
            float increment = 100f / (resolution - 1);//distance between points

            int i = 0;
            for (int x = 0; x < resolution; x++)
            {
                for (int z = 0; z < resolution; z++)
                {
                    for (int y = 0; y < resolution; y++)
                    {
                        Vector3 p = new Vector3(x * increment, y * increment, z * increment);
                        points[i].position = p;
                        points[i].color = new Color(p.x, p.y, p.z);//color of particles
                        points[i++].size = 10.0f;//size of each particle
                    }
                }

            }
        }

        // Update is called once per frame
        void Update()
        {
            if (currentResolution != resolution || points == null)
            {
                CreatePoints();
            }
            FunctionDelegate f = functionDelegates[(int)function];
            float t = Time.timeSinceLevelLoad / 10;
            for (int i = 0; i < points.Length; i++)
            {
                //Vector3 p = points[i].position;
                //p.y = f(p,t);
                //points[i].position = p;
                Color c = points[i].color;
                c.a = f(points[i].position, t);
                points[i].color = c;
            }
            particleSystem.SetParticles(points, points.Length);
        }
        private static float Linear(Vector3 p, float t)
        {
            return p.x + p.y + p.z;
            //return 1f - p.x - p.y - p.z + 0.5f * Mathf.Sin(t);
        }

        private static float Exponential(Vector3 p, float t)
        {
            return 1000f - p.x * p.x - p.y * p.y - p.z * p.z + 500.0f * Mathf.Sin(5);
        }

    }
}