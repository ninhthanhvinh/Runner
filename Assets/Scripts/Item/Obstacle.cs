using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Items
{

    PlayerController player;
    float originalSpeed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        originalSpeed = 2;
    }
    protected override void TakeAction()
    {
        FindObjectOfType<AudioManager>().PlaySFX("Obstacle");

        if (player.moveSpeed > 1)
        {
            player.moveSpeed /= 2;
        }
        player.ResetSpeed();
    }
}
