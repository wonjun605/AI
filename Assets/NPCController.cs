using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCController : MonoBehaviour
{
    public Transform targetTR;
    private NavMeshAgent nav;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // targetTR이 인스펙터 창에서 할당되어 있는지 확인하여 에러 방지
        if (targetTR != null)
        {
            nav.SetDestination(targetTR.position);
        }
    }
}