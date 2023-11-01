using System.Collections;
using UnityEngine;
using UnityEngine.UI;



namespace Timer
{
public class DestroyCubes3 : MonoBehaviour
{
public bool start;


    //void OnCollisionEnter(Collision col)
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("void");
        
        /*var timerVars = new Timerexample();
        bool start = timerVars.srt;*/

        if(col.gameObject.name == "voxel_car")
        {
            //timerVars.srt=true;
            start = false;
            Debug.Log("start");
        }
    }

}


}