using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour {
    Renderer render;
    // Start is called before the first frame update
    void Start() {
        render = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("PS4_X")) {
            render.material.color = Color.yellow;
        }
        if (Input.GetButtonDown("PS4_C")) {
            render.material.color = Color.blue;
        }
    }
}
