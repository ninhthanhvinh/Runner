using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : MonoBehaviour
{
    [SerializeField]
    protected GameObject hitVFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(hitVFX, transform.position, Quaternion.identity);
            TakeAction();
            Invoke("SelfDestroy", .3f); //Li�?u co? c�?n thi�?t kh�ng?
        }
    }

    protected abstract void TakeAction();

    void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
