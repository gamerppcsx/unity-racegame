using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes27 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car27;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 8;
            
        }
    }
        void Start()
    {
        geo = car27.GetComponent<DestroyCubes6>();
    }
}
}
