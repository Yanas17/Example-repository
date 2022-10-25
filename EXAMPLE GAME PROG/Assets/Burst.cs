using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burst : MonoBehaviour
{
    private CharacterController myCharacterController;
    public float speed = 7.0f;
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
    }
}
