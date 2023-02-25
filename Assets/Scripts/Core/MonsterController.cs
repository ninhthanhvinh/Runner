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
        Debug.Log(player.forward);
        agent.SetDestination(player.position);
        if ((player.forward.z == 1 && Mathf.Abs(transform.position.z - player.position.z) < .3f) ||
            (player.forward.x == 1 && Mathf.Abs(transform.position.x - player.position.x) < .3f) ||
            (player.forward.y == 1 && Mathf.Abs(transform.position.y - player.position.y) < .3f))
                GameObject.FindObjectOfType<GameManager>().LoseScene();
    }
}
