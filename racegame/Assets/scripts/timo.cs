using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Timer
{
public class timo : MonoBehaviour
{
    
    
    public GameObject car7;
    public GameObject car8;
    private DestroyCubes6 geo;
    private DestroyCubes7 upy;
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
    public Transform newCarLocation11;
    



    void Update()
    {
            if (geo.checkcounter==0 && upy.up == 1)
            {
                tp11();
            }else
            if (geo.checkcounter==1 && upy.up == 1)
            {
                tp1();
            }else
            if (geo.checkcounter==2 && upy.up == 1)
            {
                tp2();
            }else
            if (geo.checkcounter==3 && upy.up == 1)
            {
                tp3();
            }else
            if (geo.checkcounter==4 && upy.up == 1)
            {
                tp4();
            }else
            if (geo.checkcounter==5 && upy.up == 1)
            {
                tp5();
            }else
            if (geo.checkcounter==6 && upy.up == 1)
            {
                tp6();
            }else
            if (geo.checkcounter==7 && upy.up == 1)
            {
                tp7();
            }else
            if (geo.checkcounter==8 && upy.up ==1)
            {
                tp8();
            }else
            if (geo.checkcounter== 9 && upy.up ==1)
            {
                tp9();
            }else
            if (geo.checkcounter==10 && upy.up ==1)
            {
                tp10();
            }

      
    geo = car7.GetComponent<DestroyCubes6>();
    upy = car8.GetComponent<DestroyCubes7>();
    }
    void Start()
    {
        geo = car7.GetComponent<DestroyCubes6>();
        upy = car8.GetComponent<DestroyCubes7>();
    }

    public void tp1()
    {
       car.position = newCarLocation1.position;
       upy.up =0;
       geo.checkcounter= 1;
    }

    public void tp2()
    {
        car.position = newCarLocation2.position;
        upy.up =0;
        geo.checkcounter= 2;
    }
    public void tp3()
    {
        car.position = newCarLocation3.position;
        upy.up =0;
        geo.checkcounter= 3;
    }

    public void tp4()
    {
       car.position = newCarLocation4.position;
       upy.up =0;
       geo.checkcounter= 4;
    }
    public void tp5()
    {
        car.position = newCarLocation5.position;
        upy.up =0;
        geo.checkcounter= 5;
    }

    public void tp6()
    {
       car.position = newCarLocation6.position;
       upy.up =0;
       geo.checkcounter= 6;
    }
    public void tp7()
    {
        car.position = newCarLocation7.position;
        upy.up =0;
        geo.checkcounter= 7;
    }

    public void tp8()
    {
       car.position = newCarLocation8.position;
       upy.up =0;
       geo.checkcounter= 8;
    }   
    public void tp9()
    {
       car.position = newCarLocation9.position;
       upy.up =0;
       geo.checkcounter= 9;
    }

    public void tp10()
    {
        car.position = newCarLocation10.position;
        upy.up =0;
        geo.checkcounter= 10;
        
    }
        public void tp11()
    {
        car.position = newCarLocation11.position;
        upy.up =0;
        geo.checkcounter= 0;
        
    }

}
}
