using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggjjkk : MonoBehaviour
{
    public Transform kgm;
    public Transform kgm2;


    void FixedUpdate()
    {
        kgm.Rotate(0, 0.05f, 0);
        kgm2.Rotate(0, 0, 90);
    }
}
