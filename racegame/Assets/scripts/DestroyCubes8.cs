using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Timer
{
public class DestroyCubes8 : MonoBehaviour 
{
    public GameObject car9;

    private DestroyCubes6 geo;
 

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("wkk");

        if(col.gameObject.name == "voxel_car")
        {
            geo.checkcounter = 0;

            
        }
    }
    void Update()
    {
        geo = car9.GetComponent<DestroyCubes6>();

    }
}
}
