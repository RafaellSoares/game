using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] patrolPoints;
    private Transform player;
    [SerializeField] private float chaseDistance = 7.0f;
 
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private int currentPatrolIndex = 0;
    private bool isChashing = false;

    [SerializeField] private Animator anim;

    void Start()
    { 
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        SetDestination(patrolPoints[currentPatrolIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAnimation();
        if(!isChashing){
            if(!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.1f){
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
                SetDestination(patrolPoints[currentPatrolIndex].position);
            }
            if(Vector2.Distance(transform.position, player.position) < chaseDistance){
                isChashing = true;
                SetDestination(player.position);
            }

            
        }else{
            SetDestination(player.position);
            if(Vector2.Distance(transform.position, player.position) > chaseDistance){
                isChashing = false;
                SetDestination(patrolPoints[currentPatrolIndex].position);
            }
        }
    }

    public void SetDestination(Vector2 destination){
        navMeshAgent.destination = destination;
        navMeshAgent.isStopped = false;
    }
    public void ChangeAnimation(){
        Vector2 direction = navMeshAgent.velocity.normalized;

        if(direction != Vector2.zero){
            anim.SetFloat("Horizontal", direction.x);
            anim.SetFloat("Vertical", direction.y);
            anim.SetBool("IsMoving", true);
        }
    }
}
