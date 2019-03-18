using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sky : MonoBehaviour
{

    private int lives = 3;
    public Text livesdisplay;
    private AudioSource source;
    public AudioClip splat;
    public static bool dead = false;


    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.FindGameObjectWithTag("SFX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            GameObject[] eggos = GameObject.FindGameObjectsWithTag("Egg");
            foreach (GameObject target in eggos)
            {
                GameObject.Destroy(target);
            }

            if (Input.GetMouseButtonDown(0))
            {
                lives = 3;
                livesdisplay.text = lives.ToString();
                dead = false;
            }
        }
    }
    public int LoseALife(int lives)
    {
        return lives - 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        source.PlayOneShot(splat, 0.7f);
        lives -= 1;
        livesdisplay.text = lives.ToString();
        if (lives <= 0)
        {
            dead = true;
            SceneManager.LoadScene("GG");
        }
    }
}
