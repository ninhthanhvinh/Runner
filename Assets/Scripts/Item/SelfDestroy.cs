using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AutoDestroy", time);
    }
    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
