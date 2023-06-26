using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
   public void TeleportPlayer()
    {
        player.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
    }
}
