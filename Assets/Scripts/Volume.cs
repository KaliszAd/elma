using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

    private bool update;

    public float Music_Volume;
    public float SFX_Volume;
    public float Global_Volume;

    public Slider MusicVolume;
    public Slider SFXVolume;
    public Slider GlobalVolume;

    // Use this for initialization
    void Start () {
        this.Music_Volume = PlayerPrefs.GetFloat("music_volume");
        this.SFX_Volume = PlayerPrefs.GetFloat("sfx_volume");
        this.Global_Volume = PlayerPrefs.GetFloat("global_volume");
        setVolumes();
	}

    //Dirty Hack, vielleicht ueber Events lösen
    public void Update()
    {
        if (update)
        {
            saveVolumes();
            update = false;
        }
    }

    public void setVolumes()
    {
        MusicVolume.value = Music_Volume;
        SFXVolume.value = SFX_Volume;
        GlobalVolume.value = Global_Volume;
    }

    public void saveVolumes()
    {
        PlayerPrefs.SetFloat("music_volume", this.Music_Volume);
        PlayerPrefs.SetFloat("sfx_volume", this.SFX_Volume);
        PlayerPrefs.SetFloat("global_volume", this.Global_Volume);
    }

    public void saveMusicVolume()
    {
        this.Music_Volume = MusicVolume.value;
        update = true;
    }

    public void saveSFXVolume()
    {
        this.SFX_Volume = SFXVolume.value;
        update = true;
    }

    public void saveGlobalVolume()
    {
        this.Global_Volume = GlobalVolume.value;
        update = true;
    }
}
