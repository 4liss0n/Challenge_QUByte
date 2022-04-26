using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float vel;

    Rigidbody rb;

    void Start()
    {
        Destroy(gameObject, 5.0f);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * vel * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            StartCoroutine(Destruir(collision.gameObject));
        }
    }

    IEnumerator Destruir(GameObject inimigo)
    {
        GetComponent<Collider>().enabled = false;
        Destroy(inimigo);

        yield return new WaitForSeconds(0.3f);

        Destroy(gameObject, 1.0f);
    }
}
