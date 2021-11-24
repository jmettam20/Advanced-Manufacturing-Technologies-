using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{
    Resolution[] resolutions; //array to hold resolutions 
    public Dropdown resolutionDropdown;  //dropdown menu for resolutions 
    public AudioMixer audioMixer; // audio mixer 

    void Start() {
        //get available screen resolutions store them in an array && display array in a dropdown menu 
       resolutions = Screen.resolutions; //get res

        resolutionDropdown.ClearOptions(); //clear dropdown menu 

        List<string> options = new List<string>(); //create string to store res in

        int currentResolutionIndex = 0; //set index to 0

        //put each res into width X heaight format  
        for (int i = 0; i < resolutions.Length; i++) {
            string option = resolutions[i].width + "X" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) {
                currentResolutionIndex = i; //select res
            }
        }

        resolutionDropdown.AddOptions(options); //add list to dropdown 

        resolutionDropdown.value = currentResolutionIndex; //show current res on dropdown 

        resolutionDropdown.RefreshShownValue();  //show correct res 
    }

    public void SetVolume(float volume) {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex) {
        QualitySettings.SetQualityLevel(qualityIndex); //set quality 
    }

    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen; //set fullscreen 
    
    }

    public void setResolution(int resolutionIndex) {
        Resolution resolution = resolutions[resolutionIndex]; //get res 
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen); //set res to selecrted res in index


    }

    public void exit()
    {
        Time.timeScale = 1f;//set time to normal 
        SceneManager.LoadScene("Menu");//load menu 
    }
}
