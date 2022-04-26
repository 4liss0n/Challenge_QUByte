using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    public float moveDaCamera = 1;

    public float maxY, minY;

    private Quaternion rotacaoDaCamera;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotacaoDaCamera = transform.localRotation;
    }

    private void LateUpdate()
    {
        rotacaoDaCamera.x += Input.GetAxis("Mouse Y") * moveDaCamera *(-1);

        rotacaoDaCamera.x = Mathf.Clamp(rotacaoDaCamera.x, minY, maxY);

        transform.localRotation = Quaternion.Euler(rotacaoDaCamera.x, rotacaoDaCamera.y, rotacaoDaCamera.z);
    }
}
