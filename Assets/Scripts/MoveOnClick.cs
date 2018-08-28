using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveOnClick : MonoBehaviour {

    [SerializeField]
    private GameObject marker;

    [SerializeField]
    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                marker.transform.position = hit.point;
                agent.SetDestination(hit.point);
            }

        }
    }
}
