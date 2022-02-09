using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class StartQuestions : MonoBehaviour
{
    public GameManager manager;
    void Start () {
        this.GetComponent<StartQuestions>().enabled = false;
    }

    public void StartQuestion() {
        manager.audioFlag = true;
        manager.answers = "";
        GetComponent<BoxCollider>().enabled = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X")) {
            StartQuestion();
        }
    }
}
