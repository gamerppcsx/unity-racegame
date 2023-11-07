using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCubes6 : MonoBehaviour {
public float checkcounter;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "voxel_car")
        {
            checkcounter += 1;
        }
    }
}
