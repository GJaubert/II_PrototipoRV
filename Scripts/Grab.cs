using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject player;
    private Vector3 tokenPos;
    private Quaternion tokenRot;
    public bool inHands;

    void Start () {
        tokenPos = gameObject.transform.position;
        tokenRot = gameObject.transform.rotation;
        inHands = false;
        this.GetComponent<Grab>().enabled = false;
    }

    public void GrabObject() {
        gameObject.transform.SetParent(player.transform);
        gameObject.transform.localPosition = new Vector3(1f, -.672f, 1f);
        inHands = true;
    }

    void Update() {
        if ((Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("PS4_X")) && !inHands) {
            GetComponent<AudioSource>().Play();
            GrabObject();
        }
    }
}
