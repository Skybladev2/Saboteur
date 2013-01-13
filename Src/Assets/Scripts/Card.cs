using UnityEngine;
using System.Collections;
using System;

public class Card : MonoBehaviour
{
    private CardType cardType;
    private Texture2D imageFront;
    private Texture2D imageBack;
    private bool rotated;
    private Guid idInRound;
    private int persistentID;

    public CardType CardType
    {
        get { return cardType; }
    }

    public Texture2D ImageFront
    {
        get { return imageFront; }
    }

    public Texture2D ImageBack
    {
        get { return imageBack; }
    }

    public bool Rotated
    {
        get { return rotated; }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
