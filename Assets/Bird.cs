using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public GameObject egg;
    public GameObject birdy;
    public Vector3 bird_direction = new Vector3(1, 0, 0);
    public float bird_speed = 0.5f;
    public float screen_edge = 173.2f;
    public float random_dir_change = 0.2f;
    bool gameStarted = false;
    bool songPlaying = false;
    Vector3 originalpos;
    public AudioClip song; //the clip itself to be played upon click
    private AudioSource musicSpeaker; //the "speaker" from which the sound is played
    // Start is called before the first frame update
    void Start()
    {
        musicSpeaker = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();

        originalpos = transform.position;
        InvokeRepeating("Change_Direction_Randomly", 1, 1);
        InvokeRepeating("Spawn_One_Egg", 1, 3);
        InvokeRepeating("PlayMusic", 0, 24);


    }
    void Update()
    {
        checkForReset();
        
        if (gameStarted == true && songPlaying == false)
        {
            PlayMusic();
            songPlaying = true;
        }
        if (gameStarted == false && Sky.dead == true && Input.GetMouseButtonDown(0)) musicSpeaker.PlayOneShot(song);
        if (Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GamePlay")) gameStarted = true;
        if (gameStarted == true) {
            transform.position += bird_direction * bird_speed * Time.deltaTime;
            if (transform.position.x < -screen_edge || transform.position.x > screen_edge)
            {
                bird_speed *= -1;
        
            }
        }
        

    }
    void PlayMusic()
    {
        if(gameStarted == true)
        {
            musicSpeaker.PlayOneShot(song, 0.7F);
        }
    }
    void Change_Direction_Randomly()
    {
        if (Random.value < random_dir_change)
        {
            bird_speed *= -1;
        }
    }
    void Spawn_One_Egg()
    {
        if (gameStarted == true)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
        }

    }
    void checkForReset()
    {
        if (Sky.dead == true) ResetGame();
    }
    void ResetGame()
    {
            gameStarted = false;
            musicSpeaker.Stop();
            transform.Translate(originalpos - transform.position);
    }

}
