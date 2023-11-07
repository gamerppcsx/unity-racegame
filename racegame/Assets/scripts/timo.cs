using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Timer
{
public class timo : MonoBehaviour
{
    

    public float checkcounter;
    public GameObject car7;
    private DestroyCubes6 geo;
    public Transform car;
    public Transform newCarLocation1;
    public Transform newCarLocation2;
    public Transform newCarLocation3;
    public Transform newCarLocation4;
    public Transform newCarLocation5;
    public Transform newCarLocation6;
    public Transform newCarLocation7;
    public Transform newCarLocation8;
    public Transform newCarLocation9;
    public Transform newCarLocation10;



    void Update()
    {
            if (geo.checkcounter==1)
            {
                tp1();
            }else
            if (geo.checkcounter==2)
            {
                tp2();
            }else
            if (geo.checkcounter==3)
            {
                tp3();
            }else
            if (geo.checkcounter==4)
            {
                tp4();
            }else
            if (geo.checkcounter==5)
            {
                tp5();
            }else
            if (geo.checkcounter==6)
            {
                tp6();
            }else
            if (geo.checkcounter==7)
            {
                tp7();
            }else
            if (geo.checkcounter==8)
            {
                tp8();
            }else
            if (geo.checkcounter== 9)
            {
                tp9();
            }else
            if (geo.checkcounter==10)
            {
                tp10();
            }

        

    }
    void Start()
    {
        geo = car7.GetComponent<DestroyCubes6>();
    }

    public void tp1()
    {
       car.position = newCarLocation1.position;
    }

    public void tp2()
    {
        car.position = newCarLocation2.position;
    }
    public void tp3()
    {
        car.position = newCarLocation3.position;
    }

    public void tp4()
    {
       car.position = newCarLocation4.position;
    }
    public void tp5()
    {
        car.position = newCarLocation5.position;
    }

    public void tp6()
    {
       car.position = newCarLocation6.position;
    }
    public void tp7()
    {
        car.position = newCarLocation7.position;
    }

    public void tp8()
    {
       car.position = newCarLocation8.position;
    }   
    public void tp9()
    {
       car.position = newCarLocation9.position;
    }

    public void tp10()
    {
        car.position = newCarLocation10.position;
    }

}
}
