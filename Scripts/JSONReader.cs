using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
  public TextAsset textJSON;

  [System.Serializable]
  public class Pregunta
  {
    public string pregunta;
    public string r1;
    public string r2;
    public int p1;
    public int p2;
  }

  [System.Serializable]
  public class PreguntasList
  {
    public Pregunta[] preguntas;
  }

  public PreguntasList preguntasList;

  void Start()
  {
    preguntasList = new PreguntasList();
    preguntasList = JsonUtility.FromJson<PreguntasList>(textJSON.text);
  }
}
