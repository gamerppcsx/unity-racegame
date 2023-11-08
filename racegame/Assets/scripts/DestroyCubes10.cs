using System.Collections;
using UnityEngine;
using UnityEngine.UI;



namespace Timer
{
public class DestroyCubes10 : MonoBehaviour
{
    


    public Transform newcoliderLocation;
    public Transform newcoliderOldLocation;

    public Transform coliders;
    



    void OnTriggerEnter(Collider col)
    {
        

        if(col.gameObject.name == "voxel_car")
        {
             neen();
        }
    }


        public void neen()
    {
        coliders.position = newcoliderLocation.position;
    }


}


}