using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
   

    public bool isDead = false;
    public bool isHappy = true;
    public bool isSad = false;
    public bool isFull = false;
    public Action eventUpdateStatus;
    [SerializeField] Sprite happySprite;
    [SerializeField] Sprite sadSprite;
    [SerializeField] Sprite deadSprite;
    [SerializeField] SpriteRenderer _spriteRenderer;

    private void OnEnable()
    {
        eventUpdateStatus+= SetCharacterStatus;
    }

    private void SetCharacterStatus()
    {
        if(isHappy)
        {
            _spriteRenderer.sprite = happySprite;
        }else if(isSad)
        {
            _spriteRenderer.sprite = sadSprite;
        }
        else
        {
            _spriteRenderer.sprite = deadSprite;
        }
    }

}
