/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source files contains the methods for our
sounds including the button click sounds and
the background music. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    // the audio source 
    public AudioSource AudioSource;
    public AudioClip BackgroundMusicAudioSource;
    public AudioClip ClickSound;
    public void Start(){
        PlayBackgroundMusic(); 
    }
    public void PlayBackgroundMusic() {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip = BackgroundMusicAudioSource;
        AudioSource.loop = true;
        AudioSource.Play();
    }

    public void PlayClickSound() {
        
        AudioSource.PlayOneShot(ClickSound);
    }
}
