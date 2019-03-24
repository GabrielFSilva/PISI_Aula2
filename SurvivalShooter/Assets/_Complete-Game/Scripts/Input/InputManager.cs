using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CompleteProject;

public class InputManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerShooting playerShooting;

    public void MovePlayer(float hAxis, float vAxis)
    {
        playerMovement.Move(hAxis, vAxis);
    }

    public void TurnPlayer(Vector2 screenPoint)
    {
        playerMovement.Turning(screenPoint);
    }

    public void SetPlayerIsShooting(bool shooting)
    {
        playerShooting.SetShooting(shooting);
    }
}
