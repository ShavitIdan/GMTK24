using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Music : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private AudioSource _audioSource;
    [SerializeField] private Slider TheSlider_Music;

    void Start()
    {
        
    }

    public void Aoudio_Control()
    {
        _audioSource.volume = TheSlider_Music.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
