using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes28 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car28;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 9;
            
        }
    }
        void Start()
    {
        geo = car28.GetComponent<DestroyCubes6>();
    }
}
}
