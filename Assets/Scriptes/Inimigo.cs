using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    public float distancia;
    public float velocidade;
    public GameObject player;

    public NavMeshAgent inimigo;
    public Transform Player;

    void Start()
    {
        player = GameObject.Find("heroi");
    }

    //Movimenta��o do Inimigo
    void Update()
    {
        float d = Vector3.Distance(transform.position, player.transform.position);
        if (d < distancia)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        }

        inimigo.SetDestination(Player.position);
    }

    
}
