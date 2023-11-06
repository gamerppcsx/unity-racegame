using System.Collections;
using UnityEngine;
using UnityEngine.UI;



namespace Timer
{
public class DestroyCubes5 : MonoBehaviour
{
    
    public bool stop;
    public bool start;
    
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    private Timerexample vall;
    private DestroyCubes2 cat;
    private DestroyCubes3 caf;


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("void");
        
        /*var timerVars = new Timerexample();
        bool start = timerVars.srt;*/

        if(col.gameObject.name == "voxel_car")
        {
            //timerVars.srt=true;
            caf.stop = false;
            cat.start = false;
            Debug.Log("reset");
            vall.val = 0;
        }
    }
    void Start()
    {
        vall = car3.GetComponent<Timerexample>();
        cat = car4.GetComponent<DestroyCubes2>();
        caf = car5.GetComponent<DestroyCubes3>();
    }


}


}