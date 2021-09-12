using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class buttonscript : MonoBehaviour
{
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public float rotation_sensitivity = 100f;
    int j = 0;
    int k = 0;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        button.onClick.AddListener(() => playbutton());
        button.onClick.AddListener(() => quitbutton());
        button.onClick.AddListener(() => mainmenu());
    }
    public void playbutton()
    {
        source.PlayOneShot(sound);
        SceneManager.LoadScene("gamescene");
    }
    

    public void quitbutton()
    {
        source.PlayOneShot(sound);
        Application.Quit();
    }

    public void mainmenu()
    {
        source.PlayOneShot(sound);
        SceneManager.LoadScene("menugame");
    }

    
}
