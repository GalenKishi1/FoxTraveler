using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolBunny : MonoBehaviour
{
    public Transform[] points;
    public Transform pointFeed;
    private int destPoint = 0;
    public NavMeshAgent BunnyNav;
    public float _distanceBunny = 0.5f;
    public StatesBunny _statesBunny;

    public enum StatesBunny
    {
        Hambriento,
        Tranquilo,
        Alerta,
        Asustado
    }

    void Start()
    {
        _statesBunny = (StatesBunny)Random.Range(0, System.Enum.GetValues(typeof(StatesBunny)).Length);
        Debug.Log(_statesBunny);
        BunnyNav.GetComponent<NavMeshAgent>();
        BunnyNav.autoBraking = false;
        GotoNextPoint();
    }

    void Update()
    {
        switch (_statesBunny)
        {
            case StatesBunny.Hambriento:
                break;
            case StatesBunny.Tranquilo:
                if (!BunnyNav.pathPending && BunnyNav.remainingDistance < _distanceBunny) GotoNextPoint();
                break;
            case StatesBunny.Alerta:
                break;
            case StatesBunny.Asustado:
                break;
        }
    }

    public void GotoNextPoint()
    {
        if (points.Length == 0) return;
        BunnyNav.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
        Debug.Log(destPoint);
    }
    

}
