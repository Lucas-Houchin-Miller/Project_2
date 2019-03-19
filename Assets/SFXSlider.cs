using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour
{
    public Slider sfx;
    private AudioSource SFXsource;
    // Start is called before the first frame update

    void Start()
    {
        SFXsource = GameObject.FindGameObjectWithTag("SFX").GetComponent<AudioSource>();
        sfx.value = PlayerPrefs.GetFloat("SFX Volume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SlideSFX()
    {
        SFXsource.volume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("SFX Volume", SFXsource.volume);
    }
}
