using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoormatController : MonoBehaviour
{
    void Awake()
    {
        PlayerRecord.GetInstance().InStorePosition = new Vector3(
            transform.position.x,
            1.2f,
            transform.position.z
            );
    }
}
