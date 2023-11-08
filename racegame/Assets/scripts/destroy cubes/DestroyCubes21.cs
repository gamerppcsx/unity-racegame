using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes21 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car21;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 2;
            
        }
    }
        void Start()
    {
        geo = car21.GetComponent<DestroyCubes6>();
    }
}
}
