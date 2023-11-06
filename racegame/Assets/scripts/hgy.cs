using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Timer
{
public class hgy : MonoBehaviour
{

    private DestroyCubes3 number , scoree;
    public GameObject car4;
    

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;

    void Update()
    {
            if (number.numer==1)
            {
                txt1();
            }else
            if (number.numer==2)
            {
                txt2();
            }else
            if (number.numer==3)
            {
                txt3();
            }else
            if (number.numer==4)
            {
                txt4();
            }else
            if (number.numer==5)
            {
                txt5();
            }else
            if (number.numer==6)
            {
                txt6();
            }else
            if (number.numer==7)
            {
                txt7();
            }else
            if (number.numer==8)
            {
                txt8();
            }else
            if (number.numer== 9)
            {
                txt9();
            }else
            if (number.numer==10)
            {
                txt10();
            }

        

    }
    void Start()
    {
        number = car4.GetComponent<DestroyCubes3>();
        scoree = car4.GetComponent<DestroyCubes3>();
    }

    public void txt1()
    {
        text1.text = scoree.score . ToString ();
    }

    public void txt2()
    {

    }
    public void txt3()
    {

    }

    public void txt4()
    {

    }
    public void txt5()
    {

    }

    public void txt6()
    {

    }
    public void txt7()
    {

    }

    public void txt8()
    {

    }
    public void txt9()
    {

    }

    public void txt10()
    {

    }

}
}
