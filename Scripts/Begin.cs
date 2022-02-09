using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public Animation anim;

    void Start() {
        anim.Play("fade_intro");
        this.GetComponent<Begin>().enabled = false;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X"))) {
            GetComponent<AudioSource>().Play();
            anim.Play("fade_outro");
            StartCoroutine(WaitSeconds());
        }
    }

    IEnumerator WaitSeconds() {
        yield return new WaitForSeconds(2f);
        if (gameObject.tag == "begin") {
            SceneManager.LoadScene("MainMap");
        } else if (gameObject.tag == "end") {
            Application.Quit();
        }
    }
}
