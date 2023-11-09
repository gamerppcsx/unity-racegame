using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Timer
{
public class DestroyCubesjet : MonoBehaviour 
{
     public float kkl;

     

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("g");

        if(col.gameObject.name == "voxel_car" )
        {
        kkl=1;
        Invoke("MyFunction2", 0.2f);
        Invoke("MyFunction", 17.5f);
        }
       
    }
    void MyFunction()
    {
        kkl=0;
        
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
