using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject inimigoPrefab;
    public float frequencia;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(frequencia);

        GameObject inimigo = Instantiate(inimigoPrefab);

        inimigo.transform.position = new Vector3(transform.position.x,
            inimigoPrefab.transform.position.y, transform.position.z);
        inimigo.transform.eulerAngles = new Vector3(inimigo.transform.eulerAngles.x, 
            transform.eulerAngles.y, inimigo.transform.eulerAngles.z);

        StartCoroutine(Start());
    }

   
}
