using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Sprite vida1, vida2, vida3, vida4, vida5;

    int vidinha;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        vidinha = Jogador.vida;
        if(vidinha == 5)
        {
            spriteRenderer.sprite = vida1;
        }

        else if (vidinha == 4)
        {
            spriteRenderer.sprite = vida2;
        }
    }
}
