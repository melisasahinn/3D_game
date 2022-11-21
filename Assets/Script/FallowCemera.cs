using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCemera : MonoBehaviour
{
    Vector3 forwardOffset = new Vector3(0, 4, -4);
    public Transform player;


    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + forwardOffset, 1.0f);
        transform.LookAt(player);
    }
}
