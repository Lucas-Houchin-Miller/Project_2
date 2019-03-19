using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider music;
    private AudioSource musicsource;

    // Start is called before the first frame update
 
    void Start()
    {
        
        musicsource = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        music.value = PlayerPrefs.GetFloat("Chicken Volume");
        if (PlayerPrefs.GetFloat("Music Volume") == 0)
        {
            music.value = musicsource.volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SlideMusic()
    {
        musicsource.volume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Chicken Volume", musicsource.volume);
    }
}
