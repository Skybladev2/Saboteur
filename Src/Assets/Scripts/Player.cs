using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
    private byte order;
    private string name;
    private byte publicPlayerID;
    private List<Card> goldNuggetCards = new List<Card>();
    private Guid playerID;
    private Card dwarfCard;
    private PlayerHand playerhand;
    private List<Card> brokenTools = new List<Card>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnPlayerRegistered(PlayerInfo playerInfo)
    {
        throw new NotImplementedException();
    }

	private void OnPlayerRegistered(PublicPlayerInfo publicPlayerInfo)
	{
		throw new NotImplementedException();
	}
}
