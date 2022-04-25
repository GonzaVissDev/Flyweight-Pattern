using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGeometry
{
    // intrinsic state
    void GetShape();
   
    // extrinsic state 
    void GetColor(int size);
}
