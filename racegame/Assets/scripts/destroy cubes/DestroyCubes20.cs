using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes20 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car20;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 1;
            
        }
    }
        void Start()
    {
        geo = car20.GetComponent<DestroyCubes6>();
    }
}
}
