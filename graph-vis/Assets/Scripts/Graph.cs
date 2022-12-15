using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] Transform pointPrefab;
    [SerializeField,Range(10,100)] int resolution = 10;

    Transform[] points;

    void Awake()
    {
        points = new Transform[resolution];

        float step = 2f / resolution;
        Vector3 position = Vector3.zero;
        Vector3 scale = Vector3.one * step;

        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i] = Instantiate(pointPrefab);
            

            //setting cubes from -1 to 1
            position.x = (i + 0.5f) * step - 1f;

            //position.y = position.x * position.x * position.x;

            point.localPosition = position;   
            point.localScale = scale;
            point.SetParent(transform,false);
        }
    }

    private void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));

            point.localPosition = position;
        }
    }

}
