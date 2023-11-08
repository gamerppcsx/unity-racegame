using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes22 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car22;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 3;
            
        }
    }
        void Start()
    {
        geo = car22.GetComponent<DestroyCubes6>();
    }
}
}
