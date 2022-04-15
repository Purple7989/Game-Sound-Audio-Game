using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public AudioChanger _AChanger;
    public AudioMover _AMover;
    
    public float speed = 12f;

    public Collider _SoundBody;
    private bool isInTrigger = false;

    public int PositionCounter = 0;
    public int AudioCounter = 0;

    public void OnTriggerEnter(Collider _SoundBody)
    {
        isInTrigger = true;
    }

    public void OnTriggerExit(Collider _SoundBody)
    {
        isInTrigger = false;
    }

    private void Start()
    {
      //  _AChanger.SetNewAudio();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Position Counter is " + PositionCounter);
        Debug.Log("Audio Counter is " + AudioCounter);
        //Movement Code kinda poo poo
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        //When the player presses E and is inside the sound source trigger than they win!
        if (Input.GetKeyDown(KeyCode.E) && isInTrigger == true)
        {
            // Debug.Log("YOU WON! :)");
            // Play win sound
            // Change position of audio source and audio sound
            _AChanger.SetNewAudio();

            AudioCounter++;
            // Reset Position Counter if we are over our position limit
            if (AudioCounter >= 5)
            {
                AudioCounter = 0;
            }



            _AMover.SetNewPosition();
            // Update position counter
            PositionCounter++;
            // Reset Position Counter if we are over our position limit
            if (PositionCounter >= 5)
            {
                PositionCounter = 0;
            }
        }
    }
}
