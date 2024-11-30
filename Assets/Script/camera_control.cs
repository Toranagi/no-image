using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Vector3 CameraAmountOfCorrection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =Player.transform.position+CameraAmountOfCorrection;
    }
}
