using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonNumber : MonoBehaviour
{
    public TextMeshProUGUI code;
    public string value;
    public Animation anim;

    void Start() {
        this.GetComponent<ButtonNumber>().enabled = false;
    }

    void Update() {
        if ((Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X"))) {
            GetComponent<AudioSource>().Play();
            if (value == "Reset") {
                code.text = "";
            } else {
                code.text += value;
                if (code.text == "1337") {
                  var numbers = GameObject.FindGameObjectsWithTag("SafeNum");
                  foreach (var number in numbers) {
                      number.SetActive(false);
                  }
                  code.text = "";
                  anim.Play();
                  GameObject.FindGameObjectWithTag("Safe").GetComponent<AudioSource>().Play();
                } 
            }
        }
    }
}
