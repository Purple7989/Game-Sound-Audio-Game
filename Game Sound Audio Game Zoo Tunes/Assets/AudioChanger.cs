using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChanger : MonoBehaviour
{

    public AudioSource _AClip1;
    public AudioSource _AClip2;
    public AudioSource _AClip3;
    public AudioSource _AClip4;
    public AudioSource _AClip5;
    public AudioSource _AClip6;

    [SerializeField]
    private PlayerMovement playerMoveOBJ;

    private void Start()
    {
        _AClip1.enabled = false;
        _AClip2.enabled = false;
        _AClip3.enabled = false;
        _AClip4.enabled = false;
        _AClip5.enabled = false;
        _AClip6.enabled = false;
    }
    
    public void SetNewAudio()
    {
        switch (playerMoveOBJ.AudioCounter)
        {
            case 0:
                // Change Clip here
                _AClip1.enabled = true;
                _AClip2.enabled = false;
                _AClip3.enabled = false;
                _AClip4.enabled = false;
                _AClip5.enabled = false;
                _AClip6.enabled = false;
                break;
            case 1:
                _AClip2.enabled = true;
                _AClip1.enabled = false;
                _AClip3.enabled = false;
                _AClip4.enabled = false;
                _AClip5.enabled = false;
                _AClip6.enabled = false;
                break;
            case 2:
                _AClip3.enabled = true;
                _AClip2.enabled = false;
                _AClip4.enabled = false;
                _AClip5.enabled = false;
                _AClip6.enabled = false;
                _AClip1.enabled = false;
                break;
            case 3:
                _AClip4.enabled = true;
                _AClip2.enabled = false;
                _AClip3.enabled = false;
                _AClip5.enabled = false;
                _AClip6.enabled = false;
                _AClip1.enabled = false;
                break;
            case 4:
                _AClip5.enabled = true;
                _AClip2.enabled = false;
                _AClip3.enabled = false;
                _AClip4.enabled = false;
                _AClip6.enabled = false;
                _AClip1.enabled = false;
                break;
            case 5:
                _AClip6.enabled = true;
                _AClip2.enabled = false;
                _AClip3.enabled = false;
                _AClip4.enabled = false;
                _AClip5.enabled = false;
                _AClip1.enabled = false;
                break;
        }
    }
    
}
