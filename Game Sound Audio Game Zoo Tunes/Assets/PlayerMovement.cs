using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public AudioMover _AMover;
    
    public float speed = 12f;

    public Collider _SoundBody;
    private bool isInTrigger = false;
    [SerializeField]
    private bool MoveNow = false;
    public int PositionCounter = 0;

    public void OnTriggerEnter(Collider _SoundBody)
    {
        isInTrigger = true;
    }

    public void OnTriggerExit(Collider _SoundBody)
    {
        isInTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Code kinda poo poo
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        //When the player presses E and is inside the sound source trigger than they win!
        if (Input.GetKeyDown(KeyCode.E) && isInTrigger == true)
        {
            Debug.Log("YOU WON! :)");
            // Play win sound
            MoveNow = true;
            // Change position of audio source and audio sound
            _AMover.SetNewPosition();
            PositionCounter++;
            if (PositionCounter >= 4)
            {
                PositionCounter = 0;
            }
        }
        else
        {
            MoveNow = false;
        }
    }
}
