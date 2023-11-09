using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggjjkk : MonoBehaviour
{
    public Transform kgm;
    public Transform kgm2;


    void Update()
    {
        kgm.Rotate(0, 0.02f, 0);
        kgm2.Rotate(0, 0, 90);
    }
}
