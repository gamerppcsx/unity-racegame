using UnityEngine;
using UnityEngine.UI;

namespace Timer
{
public class Timerexample : MonoBehaviour
{

    public float val;
    public bool srt;
    public Text disvar;

    /*public void start_bool()
    {
        var classVars = new DestroyCubes2();
        srt = classVars.start;
    }*/
    void Start()
        {
            val=0;
            srt=false;
        }

    void Update() 
    { 
        //gameObject.AddComponent<DestroyCubes2>();
        class script = gameObject.AddComponent<DestroyCubes2>();
        //var classVars = new DestroyCubes2();
        //if(srt)     
        if(script.start)
            {         
                val += Time.deltaTime;    
            } 

        double b = System.Math.Round (val, 2);     

    disvar.text = b.ToString ();    
    }
    /*public void stopbutton()
    {
        srt=false;
    }   
    public void resetbutton()
    {
        srt=false;
        val=0;
    }
    public void startbutton()
    {
    srt=true;
    }*/
}
}