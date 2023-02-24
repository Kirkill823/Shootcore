using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float xRot;
    float yRot;
    float sencivity = 3;

    public Camera player;
    public GameObject playerobj;

    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X");
        yRot += Input.GetAxis("Mouse Y");

        player.transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
        playerobj.transform.rotation = Quaternion.Euler(0f, xRot, 0f);
    }
}
