using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class randomwonder : MonoBehaviour
{
    public float wanderRange;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private UnityEngine.AI.NavMeshHit navMeshHit;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent < UnityEngine.AI.NavMeshAgent > ();
        navMeshAgent.destination = this.transform.position;
        SetDestination();
	    navMeshAgent.avoidancePriority = Random.Range(0, 100);
    }

    void RandomWander() {
	//指定した目的地に障害物があるかどうか、そもそも到達可能なのかを確認して問題なければセットする。
	//pathPending 経路探索の準備できているかどうか
	if (!navMeshAgent.pathPending) {
		if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance) {
			//hasPath エージェントが経路を持っているかどうか
			//navMeshAgent.velocity.sqrMagnitudeはスピード
			if (!navMeshAgent.hasPath || navMeshAgent.velocity.sqrMagnitude == 0f) {
				SetDestination();
			}
		}
	}
}

void SetDestination() {
	Vector3 randomPos = new Vector3(Random.Range( - wanderRange, wanderRange), 0, Random.Range( - wanderRange, wanderRange));
	//SamplePositionは設定した場所から5の範囲で最も近い距離のBakeされた場所を探す。
	UnityEngine.AI.NavMesh.SamplePosition(randomPos, out navMeshHit, 5, 1);
	navMeshAgent.destination = navMeshHit.position;
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
