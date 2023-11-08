using System.Collections;
using UnityEngine;
using UnityEngine.UI;



namespace Timer
{
public class DestroyCubes11 : MonoBehaviour
{
    


    public Transform newcoliderLocation;
    public Transform newcoliderOldLocation;

    public Transform coliders;
    



    void OnTriggerEnter(Collider col)
    {
        

        if(col.gameObject.name == "voxel_car")
        {
             neen2();
        }
    }


        public void neen2()
    {
        coliders.position = newcoliderOldLocation.position;
    }


}


}