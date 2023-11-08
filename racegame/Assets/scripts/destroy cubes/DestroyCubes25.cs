using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes25 : MonoBehaviour 
{
    private DestroyCubes6 geo;
     public GameObject car25;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
           geo.checkcounter = 6;
            
        }
    }
        void Start()
    {
        geo = car25.GetComponent<DestroyCubes6>();
    }
}
}
