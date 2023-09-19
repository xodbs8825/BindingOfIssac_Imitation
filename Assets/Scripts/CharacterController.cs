using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public CharacterData character;

    private GameObject head;
    private GameObject body;

    private void Start()
    {
        head = transform.GetChild(1).gameObject;
        body = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.transform.rotation = Quaternion.Euler(0, 180, 0);
            SetAnimation(KeyCode.W, true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            body.transform.rotation = Quaternion.Euler(0, 0, 0);
            SetAnimation(KeyCode.S, true);
        }
        else
        {
            SetAnimation(KeyCode.W, false);
            SetAnimation(KeyCode.S, false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.transform.rotation = Quaternion.Euler(0, 180, 0);
            SetAnimation(KeyCode.A, true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            body.transform.rotation = Quaternion.Euler(0, 0, 0);
            SetAnimation(KeyCode.D, true);
        }
        else
        {
            SetAnimation(KeyCode.A, false);
            SetAnimation(KeyCode.D, false);
        }
    }

    private void SetAnimation(KeyCode keyCode, bool b)
    {
        head.GetComponent<Animator>().SetBool(keyCode.ToString().ToLower() + "KeyPressed", b);

        if (keyCode == KeyCode.A)
        {
            body.GetComponent<Animator>().SetBool("dKeyPressed", b);
        }
        else if (keyCode == KeyCode.W)
        {
            body.GetComponent<Animator>().SetBool("sKeyPressed", b);
        }
        else
        {
            body.GetComponent<Animator>().SetBool(keyCode.ToString().ToLower() + "KeyPressed", b);
        }
    }
}
