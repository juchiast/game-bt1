using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Vector3 pos;
    Animator animator;
    SpriteRenderer ren;
    int walking = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        animator = GetComponent<Animator>();
        ren = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            if (Input.GetKey(KeyCode.D)) {
                walking = 1;
            } else {
                walking = -1;
            }
        } else {
            walking = 0;
        }

        animator.SetInteger("walking", walking);
        if (walking == 1) {
            ren.flipX = false;
        } else if (walking == -1) {
            ren.flipX = true;
        }
        pos.x += walking * 0.06f;
        transform.position = pos;
    }
}
