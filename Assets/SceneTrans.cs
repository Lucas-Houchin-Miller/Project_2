using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    private void Awake()
    {
        //SceneManager.LoadScene("StartScreen");
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("StartScreen"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
        Nest.score = 0;
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("GamePlay"));
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    //edit
    public void StartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
