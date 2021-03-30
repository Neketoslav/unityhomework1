using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolEnemy : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _navMeshAgent;
    [SerializeField]
    private Transform[] _waypoints;
    int m_CurrentWaypointIndex;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _watchArea = 5f;
    [SerializeField]
    private float _attackRange = 3f;
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private int _damage = 1;
    private Animator _animationRun;

    void Start()
    {
        _animationRun = GetComponent<Animator>();
        _navMeshAgent.SetDestination(_waypoints[0].position);
    } 

    void Update()
    {
        if (Vector3.Distance(transform.position, _target.transform.position) <= _watchArea)
        {
            _animationRun.SetTrigger("Run");
            transform.LookAt(_target.position);
            transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));          
        }
        else 
        {
           if (_navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance)
           m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % _waypoints.Length;
           _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);
        } 
    }
    private void Attack()
    {
        if (gameObject.CompareTag("Player"))
        {
            
            var enemy = GetComponent<Health>();
            enemy.Hurt(_damage);
        }
    }
}
