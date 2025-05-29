using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;

    private void Start()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();

        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
