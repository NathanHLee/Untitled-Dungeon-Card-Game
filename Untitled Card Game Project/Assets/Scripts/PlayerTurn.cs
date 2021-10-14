using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum SelectedPlayerState { START, PLAYERONE, PLAYERTWO, WON, LOST }

public class PlayerTurn : MonoBehaviour
{
    public SelectedPlayerState state;

    // Start is called before the first frame update
    void Start()
    {
        state = SelectedPlayerState.START;
        SetupHand();
    }

    void SetupHand()
    {

    }
}
