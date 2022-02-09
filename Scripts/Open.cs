using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject token;
    public Animation anim;
    public AudioSource errorAudioFile;

    void Start() {
        this.GetComponent<Open>().enabled = false;
    }

    public void OpenObject() {
        anim.Play();
        token.SetActive(false);
        token.GetComponent<Grab>().inHands = false;
        AudioSource[] audios = GetComponents<AudioSource>();
        foreach (AudioSource audio in audios) {
          audio.Play();
        }
        if (this.gameObject.tag == "USB") {
            GameObject.FindGameObjectWithTag("QuestionScreen").GetComponent<BoxCollider>().enabled = true;
        }
    }

    void Update() {
        if ((Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X"))) {
            if (token.GetComponent<Grab>().inHands) {
                OpenObject();
            } else {
                // TODO: audio diciendo "necesitas una cosita para abrir eso"
                Debug.Log("No tienes token");
                errorAudioFile.Play();
            }
        }
    }
}
