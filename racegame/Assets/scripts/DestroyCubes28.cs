using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCubes28 : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "voxel_car")
        {
            SceneManager.LoadScene("menu5");
        }
    }
}
