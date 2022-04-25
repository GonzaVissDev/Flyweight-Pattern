using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour, IGeometry
{
  
        // shape of geometry will be constant - intrinsic state
        public void GetShape()
        {
            Debug.Log("This is a Rectangle shape object");
        }
        // color of geometry will dependent on size - extrinsic state
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Debug.Log("Rectangle is filled with BLUE color");
            }
            else
            {
                Debug.Log("Rectangle is filled with RED color");
            }
        }
    }
