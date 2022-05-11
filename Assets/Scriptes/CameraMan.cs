using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    public GameObject alvo;
    public GameObject posicao;
    private RaycastHit hit;

    public float moveXDaCamera, moveYDaCamera;

    private Quaternion rotacaoDaCamera;

    public float maxY, minY;

    

    


    // Start is called before the first frame update
    

    private void LateUpdate()
    {
        /////////MOVIMENTAÇÃO Y DA CAMERA//////////
        rotacaoDaCamera.x += Input.GetAxis("Mouse Y") * moveYDaCamera * (-1);

        rotacaoDaCamera.x = Mathf.Clamp(rotacaoDaCamera.x, minY, maxY);

        transform.localRotation = Quaternion.Euler(rotacaoDaCamera.x, rotacaoDaCamera.y, rotacaoDaCamera.z);
    }
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotacaoDaCamera = transform.localRotation;
    }
    private void FixedUpdate()
    {
        transform.LookAt(alvo.transform);

        if (!Physics.Linecast(alvo.transform.position, posicao.transform.position))
        {
            transform.position = Vector3.Lerp(transform.position, posicao.transform.position, moveXDaCamera*Time.deltaTime);
        }
        else if (Physics.Linecast(alvo.transform.position, posicao.transform.position, out hit))
        {
            transform.position = Vector3.Lerp(transform.position, hit.point, moveXDaCamera * Time.deltaTime);
        }

        
    }
}
