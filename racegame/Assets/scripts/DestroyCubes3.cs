using System.Collections;
using UnityEngine;
using UnityEngine.UI;



namespace Timer
{
public class DestroyCubes3 : MonoBehaviour
{
    
    public bool stop;
    public float score;
    public float numer;
    
    public GameObject car3;
    private Timerexample vall;


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("void");
        
        /*var timerVars = new Timerexample();
        bool start = timerVars.srt;*/

        if(col.gameObject.name == "voxel_car")
        {
            //timerVars.srt=true;
            stop = true;
            Debug.Log("stop");
            numer += 1;
        }
    }
    private void FixedUpdate()
    {
        if(stop == true)
        {
           score = vall.val;
           
        } 
    }
    void Start()
    {
        vall = car3.GetComponent<Timerexample>();
        
    }


}


}