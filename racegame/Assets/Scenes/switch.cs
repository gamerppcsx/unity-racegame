using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
  public void playGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy");
    }
    public void Back()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Additive);
	SceneManager.LoadScene("menu1");
    }
        public void links()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Additive);
	SceneManager.LoadScene("menu2");
    }
        public void playgame2()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 2");
    }
            public void menu3()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu3");
    }
    
}
