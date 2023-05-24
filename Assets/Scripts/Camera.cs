using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Mario;
    
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Mario.transform.position.x;
        transform.position = position;
    }
}
