using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meny : MonoBehaviour
{
    private float ispressing;
    private bool goBool;

    private void FixedUpdate() {
        GetInput();
    }
    private void GetInput() {

        ispressing = Input.GetAxis("Cancel");
        if(ispressing > 0)
        {
            SceneManager.LoadScene("menuXD");
        }
    }
}