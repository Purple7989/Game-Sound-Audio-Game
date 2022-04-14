using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMover : MonoBehaviour
{
    public GameObject myObject;
    public GameObject Position1;
    public GameObject Position2;
    public GameObject Position3;
    public GameObject Position4;
    public GameObject Position5;

    public PlayerMovement playerMoveOBJ;
    public AudioSource _AClip1;
    public AudioSource _AClip2;
    public AudioSource _AClip3;
    public AudioSource _AClip4;
    public AudioSource _AClip5;
    public AudioSource _AClip6;



    public void SetNewPosition()
    {
        switch (playerMoveOBJ.PositionCounter)
        {
            case 0:

                myObject.transform.position = Position1.transform.position;
                break;
            case 1:
                
                myObject.transform.position = Position2.transform.position;
                break;
            case 2:
                myObject.transform.position = Position3.transform.position;
                break;
            case 3:
                myObject.transform.position = Position4.transform.position;
                break;
            case 4:
                myObject.transform.position = Position5.transform.position;
                break;
        }    
   }

    // Update is called once per frame
    void Update()
    {
    }
}
