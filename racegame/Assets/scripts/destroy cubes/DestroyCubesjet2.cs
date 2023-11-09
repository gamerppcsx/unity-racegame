using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Timer
{
public class DestroyCubesjet2 : MonoBehaviour 
{
     private DestroyCubesjet kkl2 ;
     public GameObject jet;

     public Transform jety;
     public Transform jety2;
     public Transform jety3;
     public Transform jety4;

     
    
    void Start()
    {
        kkl2 = jet.GetComponent<DestroyCubesjet>();

    }
    void Update()
    {
      if(kkl2.kkl==2)
    {
         jety.position = jety2.position;
      
         
    }
          if(kkl2.kkl==1)
    {
      
         jety.position = jety3.position;
         
    }
              if(kkl2.kkl==0)
    {
      
         jety.position = jety4.position;
         
    }
    }

}
}
