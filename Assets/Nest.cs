using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nest : MonoBehaviour
{
    public float screen_edge = 173.2f;
    public float nest_speed = 1.3f;
    bool gameStarted = false;
    private AudioSource sfxSpeaker;
    public AudioClip shwop;
    public static int score = 0;
    public Text scoredisplay;
    public Text hiscore;
    private Vector3 originalpos;
   
    // Start is called before the first frame update
    void Start()
    {
        sfxSpeaker = GameObject.FindGameObjectWithTag("SFX").GetComponent<AudioSource>();
        //sfxSpeaker.volume = PlayerPrefs.GetFloat("SFX Volume");
        originalpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        checkForReset();
        if (Sky.dead == true) gameStarted = false;
        if (Sky.dead == true && gameStarted == false && Input.GetMouseButtonDown(0)) scoredisplay.text = score.ToString();


        if (Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GamePlay")) gameStarted = true;
        if (gameStarted == true)
        {
            hiscore.text = PlayerPrefs.GetInt("hiscore0").ToString();
            transform.position += nest_speed * new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime;
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -screen_edge, screen_edge), transform.position.y, 0);
        /*if (transform.position.x > screen_edge)
        {
            transform.position = new Vector3(screen_edge, transform.position.y, 0);
        }
        if (transform.position.x < -screen_edge)
        {
            transform.position = new Vector3(-screen_edge, transform.position.y, 0);
        }
        */
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        sfxSpeaker.PlayOneShot(shwop, 0.7f);
        score += 1;
        scoredisplay.text = score.ToString();
    }
    void checkForReset()
    {
        if (Sky.dead == true) ResetGame();
    }
    void ResetGame()
    {
        //save the score in PlayerPrefs;
        gameStarted = false;
        transform.Translate(originalpos - transform.position);
        
    }
}
