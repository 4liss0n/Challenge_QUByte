using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject projetilPrefab;

    public float moveYDaCamera;
    private Quaternion rotacaoDaCamera;
    public float maxY, minY;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            //Instantiate(projetilPrefab, transform.position, GameObject.FindGameObjectWithTag("Jogador").transform.rotation);
            Instantiate(projetilPrefab, transform.position, transform.rotation);
        }
    }
    private void LateUpdate()
    {
        /////////MOVIMENTAÇÃO Y DA CAMERA//////////
        rotacaoDaCamera.x += Input.GetAxis("Mouse Y") * moveYDaCamera * (-1);

        rotacaoDaCamera.x = Mathf.Clamp(rotacaoDaCamera.x, minY, maxY);

        transform.localRotation = Quaternion.Euler(rotacaoDaCamera.x, rotacaoDaCamera.y, rotacaoDaCamera.z);
    }
}
