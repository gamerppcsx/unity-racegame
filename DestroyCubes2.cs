using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class DestroyCubes2 : MonoBehaviour
{
    public bool start;

    void OnCollisionEnter(Collision col)
    {
        /*var timerVars = new Timerexample();
        bool start = timerVars.srt;*/

        if (col.gameObject.name == "voxel_car")
        {
            //timerVars.srt=true;
            start = true;
        }
    }

}


