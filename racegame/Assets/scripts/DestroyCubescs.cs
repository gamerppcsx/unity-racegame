using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCubescs : MonoBehaviour {
    public float gamer;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "voxel_car")
        {
            gamer = 1;
            Invoke("Myass2", 15.5f);
            
        }

    }
        void Myass2()
    {
       gamer =0;
        
    }

}
