using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public GameObject Player;

    public Vector3 PlayerPos;
    int CI;


    void Update()
    {

        if (Input.GetButtonDown("w") == true)
        {
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            CI = 1;
            PlayerPositionAnim();
        }
        if (Input.GetButtonDown("a") == true)
        {
            Player.transform.rotation = Quaternion.Euler(0, 0, 90);
            CI = 2;
            PlayerPositionAnim();
        }
        if (Input.GetButtonDown("s") == true)
        {
            Player.transform.rotation = Quaternion.Euler(0, 0, 180);
            CI = 3;
            PlayerPositionAnim();
        }
        if (Input.GetButtonDown("d") == true)
        {
            Player.transform.rotation = Quaternion.Euler(0, 0, -90);
            CI = 4;
            PlayerPositionAnim();
        }
    }
    public void PlayerPositionAnim()
    {
        PlayerPos = Player.transform.position;
        float newX = Player.transform.position.x;
        float newY = Player.transform.position.y + 48f;
        float newZ = Player.transform.position.z;
        Player.transform.position = new Vector3(newX, newY, newZ);
    }
}

