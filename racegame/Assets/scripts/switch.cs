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
    Time.timeScale = 1f;
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
    Time.timeScale = 1f;
    }
        public void playgame2()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 2");
    Time.timeScale = 1f;
    }
            public void menu3()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu3");
    Time.timeScale = 1f;
    }
            public void playgame3()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 3");
    Time.timeScale = 1f;
    }
                public void playgame4()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 4");
    Time.timeScale = 1f;
    }
                public void menu4()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu4");
    Time.timeScale = 1f;
    }
                public void playgame5()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("secondairy 5");
    Time.timeScale = 1f;
    }
                    public void menu5()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menu5");
    Time.timeScale = 1f;
    }
                        public void controles()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("controles");
    Time.timeScale = 1f;
    }
                            public void menuxd()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
	SceneManager.LoadScene("menuXD");
    Time.timeScale = 1f;
    }
}
