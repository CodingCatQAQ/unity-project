using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapHead : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 0f));
    }
}
