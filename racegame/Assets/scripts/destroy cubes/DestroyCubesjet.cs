using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Timer
{
public class DestroyCubesjet : MonoBehaviour 
{
     public float kkl;
     public ParticleSystem ParticleSystem;
     public ParticleSystem ParticleSystem2;
     public ParticleSystem ParticleSystem3;

     

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("g");

        if(col.gameObject.name == "voxel_car" )
        {
        kkl=1;
        Invoke("MyFunction2", 0.2f);
        Invoke("MyFunction", 17.5f);
        ParticleSystem.Play ();
        ParticleSystem2.Play ();
        ParticleSystem3.Play ();
        }
       
    }
    void MyFunction()
    {
        kkl=0;
        
    ParticleSystem.Stop ();
    ParticleSystem2.Stop ();
    ParticleSystem3.Stop ();
        
    }
        void MyFunction2()
    {
        kkl=2;
        
    }
    void update()
    {
        CancelInvoke();
    }



}
}
