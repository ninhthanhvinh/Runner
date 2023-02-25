using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinBox : MonoBehaviour
{
    Transform player;
    int skinNum;
    [SerializeField]
    GameObject hitVFX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        skinNum = player.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().PlaySFX("CollectSkin");
            Instantiate(hitVFX, transform.position, Quaternion.identity);
            SkinChange(other.transform);
        }
    }

    void SkinChange(Transform player)
    {
        //Tạo hiệu ứng
        
        
        var ranSkin = Random.Range(0, skinNum);
        player.GetChild(GetActiveChildIndex(player)).gameObject.SetActive(false);
        player.GetChild(ranSkin).gameObject.SetActive(true);

    }

    int GetActiveChildIndex(Transform player)
    {
        int i;
        for (i = 0; i < skinNum; i++)
        {
            if (player.GetChild(i).gameObject.activeSelf)
                break;
        }
        return i;
    }
}
