using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCubes : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "voxel_car")
        {
            SceneManager.LoadScene("menu1");
        }
    }
}
