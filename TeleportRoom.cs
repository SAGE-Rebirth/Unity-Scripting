using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRoom : MonoBehaviour
{
    public Transform Player;
    public Transform StartPos;
    public Transform Destination;

    public void TeleportFrom()
    {
        Player.transform.position = StartPos.transform.position;
    }

    public void TeleportTo()
    {
        Player.transform.position = Destination.transform.position;
    }
}
