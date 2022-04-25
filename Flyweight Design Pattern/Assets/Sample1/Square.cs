using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour, IGeometry
{
  
        // shape of geometry will be constant - intrinsic state
        public void GetShape()
        {
           Debug.Log("This is a square shape object");
        }
        // color of geometry will dependent on size - extrinsic state
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Debug.Log("Square is filled with BLACK color");
            }
            else
            {
                Debug.Log("Square is filled with GREEN color");
            }
        }
    }
