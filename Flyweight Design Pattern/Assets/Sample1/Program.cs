using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{

    private void Start()
    {
           GeometryFActory geometryFactory = new GeometryFActory();
            Debug.Log("-------------- Object Details-----------------");
            
        IGeometry geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(9);


        Debug.Log("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(3);


        Debug.Log("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(9);


        Debug.Log("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(3);
        Debug.Log("-------------- Object Count-----------------");
            int ObjectCount = geometryFactory.ObjectCount();
        Debug.Log("Total objects created: " + ObjectCount);

        
        }
}


