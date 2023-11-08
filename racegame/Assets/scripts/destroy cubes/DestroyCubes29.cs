using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes29 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car29;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 10;
            
        }
    }
        void Start()
    {
        geo = car29.GetComponent<DestroyCubes6>();
    }
}
}
