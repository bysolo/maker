using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {
    public GameObject Optionss,soundd,unSound;
    void Start ()
    {
        Optionss.SetActive(false);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Loading");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Options()
    {
        Optionss.SetActive(true);
    }
    public void Cikis()
    {
        Optionss.SetActive(false);
    }
    public void Sound()
    {
        soundd.SetActive(false);
        unSound.SetActive(true);
    }
    public void UnSound()
    {
        soundd.SetActive(true);
        unSound.SetActive(false);
    }
}
