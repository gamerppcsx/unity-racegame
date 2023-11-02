using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCubetttgtg : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "voxel_car")
        {
            SceneManager.LoadScene("secondairy");
        }
    }
}
