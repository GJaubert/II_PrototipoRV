using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public JSONReader reader;
    public TextMeshProUGUI questionScreen;
    public TextMeshProUGUI answerScreen1;
    public TextMeshProUGUI answerScreen2;
    public List<AudioSource> questionsAudioArray;
    public GameObject audios;
    public bool audioFlag;
    public string answers;
    public GameObject screenObject1;
    public GameObject screenObject2;
    public Animation anim;

    void Start() {
        anim.Play("fade_intro");
        answers = "null";
        audioFlag = false;
        int childCnt = audios.transform.childCount;
        for (int i = 0; i < childCnt; i++) {
            AudioSource audio = audios.transform.GetChild(i).GetComponent<AudioSource>();
            questionsAudioArray.Add(audio);
        }
    }

    int CalculateScore() {
        int score = 0;
        for (int i = 0; i < 10; i++) {
            if (answers[i] == '0') {
                score += reader.preguntasList.preguntas[i].p1;
            } else {
                score += reader.preguntasList.preguntas[i].p2;
            }
        }
        return score;
    }

    void Endgame() {
        int score = CalculateScore();
        GetComponent<AudioSource>().Play();
        if (score >= 6) {
            StartCoroutine(GoToScene("GoodEnding"));
        } else {
            StartCoroutine(GoToScene("BadEnding"));
        }
    }

    IEnumerator GoToScene(string escena) {
        yield return new WaitForSeconds(13f);
        anim.Play("fade_outro");
        yield return new WaitForSeconds(2f);
        Debug.Log("Endgame");
        SceneManager.LoadScene(escena);
    }

    void Update() {
        if (answers != "null" && audioFlag) {
            if (answers.Length >= 10) {
                questionScreen.text = "CUESTIONARIO FINALIZADO";
                answerScreen1.text = "";
                answerScreen2.text = "";
                Endgame();
            } else {
                screenObject1.GetComponent<BoxCollider>().enabled = true;
                screenObject2.GetComponent<BoxCollider>().enabled = true;
                questionScreen.text = reader.preguntasList.preguntas[answers.Length].pregunta;
                answerScreen1.text = reader.preguntasList.preguntas[answers.Length].r1;
                answerScreen2.text = reader.preguntasList.preguntas[answers.Length].r2;
                questionsAudioArray[answers.Length].Play();
            }
            audioFlag = false;
        }
    }
}
