using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes26 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car26;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 7;
            
        }
    }
        void Start()
    {
        geo = car26.GetComponent<DestroyCubes6>();
    }
}
}
