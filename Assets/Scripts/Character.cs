using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour {

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private NavMeshAgent agent;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(transform.position, agent.pathEndPosition) > 0.1f)
        {
            anim.SetBool("InMotion", true);
        }
        else
        {
            anim.SetBool("InMotion", false);
        }

        /*if (agent.velocity.x != 0 || agent.velocity.y != 0)
        {
            anim.SetBool("InMotion", true);
        }
        else
        {
            anim.SetBool("InMotion", false);
        }*/
	}


}
