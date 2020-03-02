using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class destination : MonoBehaviour
{
    public GameObject arrow;
    private List<GameObject> arrows = new List<GameObject>();
    private string target = "Target1";
    private NavMeshAgent agent;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        StartCoroutine("Instance");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = GameObject.FindGameObjectWithTag(target).transform.position;
    }

    public void Change_target(string target) 
    {
        this.target = target;
        destroy();
        StartCoroutine("Instance");
    }

    public void destroy()
    {
        foreach (GameObject i in arrows) Destroy(i);
        arrows = new List<GameObject>();
    }

    IEnumerator Instance()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject obj;
        obj = Instantiate(arrow, transform.position, Quaternion.identity);
        arrows.Add(obj);
        Debug.Log(arrows[0]);

        if (agent.hasPath) StartCoroutine("Instance");
    }
}
