using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject neeedle ;
    public CarController RR;
    public float startPosiziton = 220f,endPosition = -41;
    private float desiredPosition;
    public float vehicleSpeed;


    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        vehicleSpeed = RR.KPH;
        updateNeedle();

    }

    public void updateNeedle(){
        desiredPosition = startPosiziton - endPosition;
        float temp = vehicleSpeed / 180;
        neeedle.transform.eulerAngles = new Vector3(0,0,(startPosiziton - temp * desiredPosition));



    }
}
