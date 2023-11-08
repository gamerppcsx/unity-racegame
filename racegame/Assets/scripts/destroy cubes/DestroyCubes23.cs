using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes23 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car23;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 4;
            
        }
    }
        void Start()
    {
        geo = car23.GetComponent<DestroyCubes6>();
    }
}
}
