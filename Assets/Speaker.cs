using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{
    public AudioSource speaker;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
 * Settings menu shouldnt matter...
 * xx.gameObject.SetActive(!settingsMenu.gameObject.activeSelf); // turns things on / off
 * 2 references to sources
 * musicSource.volume - slider.value;
 * private void loadsettings: float vol = PlayerPrefs.GetFloat("Music Volume", 50) and then musicSource.volume = vol;
 * "Muted", 0) == 0? false : true;
 * musicslider.value = musicVolume;
 * Inside each function, put PlayerPrefs.SetFloat("Music Volume", musicSource.volume); so that and SFX get the same treatment
 */
}

