using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeEndings : MonoBehaviour
{
    public Animation anim;
    // Start is called before the first frame update
    void Start() {
        anim.Play("fade_intro");
    }
}
