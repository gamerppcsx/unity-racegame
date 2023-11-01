using UnityEngine;
using UnityEngine.UI;

namespace Timer
{
public class Timerexample : MonoBehaviour
{

    public float val;
    public bool srt;
    public Text disvar;
    public GameObject car;
    public GameObject car2;
    private DestroyCubes2 collision_bool;
    private DestroyCubes3 collision_bool2;
    /*public void start_bool()
    {
        var classVars = new DestroyCubes2();
        srt = classVars.start;
    }*/
    void Start()
        {
            val=0;
            srt=false;
            collision_bool = car.GetComponent<DestroyCubes2>();
            collision_bool2 = car2.GetComponent<DestroyCubes3>();
        }
    void Update() 
    { 
        //gameObject.AddComponent<DestroyCubes2>();
        //class script = gameObject.AddComponent<DestroyCubes2>();
        //var classVars = new DestroyCubes2();
        //if(srt)     
        //if(DestroyCubes2.start)
        if(collision_bool.start == true && collision_bool2.stop == false)
            {         
                val += Time.deltaTime;    
            } 

        double b = System.Math.Round (val, 2);  
           

    disvar.text = b.ToString ();    
    }
    public void stopbutton()
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
    }
}

}