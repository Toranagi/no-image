using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_contro : MonoBehaviour
{
    [SerializeField,Header("�̗�")]
    float HP;
    [SerializeField, Header("�U����")]
    int STR;
    [SerializeField, Header("�ړ����x")]
    float speed;
   

    void InputKey()
    {
        var move = new Vector3();

        if (Input.GetKey(KeyCode.A))
        {
            move.x-=speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            move.z += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move.x += speed * Time.deltaTime;
        }
       

        transform.position += move;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputKey();
    }
}
