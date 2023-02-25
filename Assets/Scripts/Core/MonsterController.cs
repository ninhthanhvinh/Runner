using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.z - player.position.z) < .5f)
            GameObject.FindObjectOfType<GameManager>().LoseScene();
    }
}
