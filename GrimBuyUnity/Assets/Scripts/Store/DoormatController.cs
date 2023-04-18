using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoormatController : MonoBehaviour
{
    public GameObject Player;

    void Awake()
    {
        Player = GameObject.Find("Player");
        float doormatX = transform.position.x;
        float doormatZ = transform.position.z;
        Player.transform.position = new Vector3(
            doormatX,
            Player.transform.position.y,
            doormatZ
            );
    }
}
