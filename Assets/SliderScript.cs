using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public AudioSource nestone;
    public AudioSource chickensong;
    private Slider thisslider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SlideSFX()
    {
        nestone.volume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Nest Volume", nestone.volume);   
    }
    public void SlideMusic()
    {
        chickensong.volume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Chicken Volume", chickensong.volume);
    }
}
