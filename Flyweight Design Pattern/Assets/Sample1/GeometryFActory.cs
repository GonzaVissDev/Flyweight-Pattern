using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryFActory : MonoBehaviour
{
   
        Dictionary<string, IGeometry> geometries = new Dictionary<string, IGeometry>();
       
    // returns total number of created objects
        public int ObjectCount()
        {
            return geometries.Count;
        }

    // responsible for creating and managing objects
    public IGeometry getGeometryObject(string name)
    {
        IGeometry geometry = new Rectangle() ;

        if (geometries.ContainsKey(name))
        {
            return geometries[name];
        }
        else
        {
            if (name == "Rectangle")
            {
                geometry = new Rectangle();
                geometries.Add("Rectangle", geometry);
            }
            else if (name == "Square")
            {
                geometry = new Square();
                geometries.Add("Square", geometry);
            }
            else
            {
                Debug.Log("This type of object can not be created");
            }
        }
        return geometry;
    }
}
 

