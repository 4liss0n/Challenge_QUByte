using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject projetilPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(projetilPrefab, transform.position, GameObject.FindGameObjectWithTag("Jogador").transform.rotation);
            Instantiate(projetilPrefab, transform.position, transform.rotation);
        }
    }
}
