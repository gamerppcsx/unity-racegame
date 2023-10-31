using UnityEngine.UI;
using UnityEngine;
using System.Collections;

 
public class SimpleTimer : MonoBehaviour
{
    public bool isRacing;
    Text txt;
 
    void Awake()
    {
        txt = GetComponent<Text>();
    }
 
    void Start()
    {
        isRacing = true;
    }
 
    void Update ()
    {
        if(isRacing)
            txt.text = Time.time.ToString("#.00");
    }
}