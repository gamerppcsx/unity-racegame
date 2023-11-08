using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes24 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car24;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 5;
            
        }
    }
        void Start()
    {
        geo = car24.GetComponent<DestroyCubes6>();
    }
}
}
