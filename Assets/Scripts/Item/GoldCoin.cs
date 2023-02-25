using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : Items
{
    [SerializeField]
    int value;

    // Start is called before the first frame update
    void Start()
    {
        value = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void TakeAction()
    {
        FindObjectOfType<AudioManager>().PlaySFX("CollectCoin");
        //Cộng thêm tiền
        GameManager.point += value;
    }
}
