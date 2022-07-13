using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ia : MonoBehaviour
{
    NavMeshAgent agent;
    public LayerMask piso;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit info;

            if(Physics.Raycast(rayo, out info, 100f, piso)){
                agent.SetDestination(info.point);
            }
        }

        if(agent.remainingDistance <= agent.stoppingDistance) animator.SetBool("estaCorriendo", false);
        else animator.SetBool("estaCorriendo", true);
    }
}
