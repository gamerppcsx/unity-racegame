using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
  public void playGame1()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy");
    }
    public void menu1()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Additive);
	SceneManager.LoadScene("menu1");
    }
        public void menu2()
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
            public void playgame3()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 3");
    }
                public void playgame4()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 4");
    }
                public void menu4()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu4");
    }
                public void playgame5()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 5");
    }
                    public void menu5()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu5");
    }
}
