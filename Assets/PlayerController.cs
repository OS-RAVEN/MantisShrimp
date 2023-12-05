using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public float WorkSpeed = 0.1f;
    public float SlideSpeed = 0.1f;
    public float Countdown =10.0f;



    void Update()
    {
        float x = joystick.Horizontal * SlideSpeed;
        float y = joystick.Vertical * WorkSpeed;

        Countdown -= Time.deltaTime;

        /*お腹が空いたとき*/
        if (Countdown <= 3f && Countdown >= 0f)
        {
            transform.position += new Vector3(x, 0, y + 0.01f);
        }
        /*空腹で動けない*/
        else if (Countdown <= 0f)
        {
            transform.position += new Vector3(0, 0, 0);
        }
        /*通常時*/
        else
        {
            transform.position += new Vector3(x, 0, y);
        }

    }
}