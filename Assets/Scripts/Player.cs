using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;


    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.A))
            player.position += new Vector3(-1, 0, 0) / 10;
        if (Input.GetKey(KeyCode.D))
            player.position += new Vector3(1, 0, 0) / 10;

        if (Input.GetKey(KeyCode.S))
            player.position += new Vector3(0, 0, -1) / 10;

        if (Input.GetKey(KeyCode.W))

            player.position += new Vector3(0, 0, 1) / 10;

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("trigger "+collision.rigidbody.name);

    }
}
