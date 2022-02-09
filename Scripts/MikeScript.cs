using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeScript : MonoBehaviour {
  private Transform tf;
  private Transform plTf;

  void Awake() {
    tf = GetComponent<Transform>();
    plTf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
  }

  void Update() {
    tf.LookAt(plTf);
  }
}