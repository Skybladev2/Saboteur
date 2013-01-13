using UnityEngine;
using System.Collections;

public enum GameState
{
    Undefined = 0,
    Error = 1,
    GameCreation = 2,
    PlayersConnectionDisconnection = 3,
    GameRunning = 4,
    GameDestruction = 5,
    PlayersTravelling = 6
}
