using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : Items
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
        FindObjectOfType<AudioManager>().PlaySFX("SpeedPotion");

        if (player.moveSpeed < 4)
        {
            player.moveSpeed *= 2;
        }
        player.ResetSpeed();
    }
}    

