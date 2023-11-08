using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes30 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car30;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 0;
            
        }
    }
        void Start()
    {
        geo = car30.GetComponent<DestroyCubes6>();
    }
}
}
