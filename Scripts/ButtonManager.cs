using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public string value;
    public GameManager manager;

    void Start () {
        this.GetComponent<ButtonManager>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    public void AnswerQuestion() {
        manager.answers += value; 
        manager.audioFlag = true;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X")) {
            AnswerQuestion();
        }
    }
}
