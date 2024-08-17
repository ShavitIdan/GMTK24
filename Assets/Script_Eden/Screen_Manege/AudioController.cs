using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void Master_Control(float value) => audioMixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    public void Music_Control(float value) => audioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    public void SFX_Control(float value) => audioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);

}
