using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{ 
    public float vel, alturaDoPulo, gravidade;
    float moveX, moveY, moveZ, vel_2;

    public static int vida;

    Animation an;

    Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        an = GetComponent<Animation>();
    }



    // Update is called once per frame
    void Update()
    {
        vida = 4;

        /////////////////MOVER DE UM LADO PRO OUTRO////////////////////////////////////

        CharacterController controller = GetComponent<CharacterController>();

        
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");
        if (moveX != 0 && moveZ != 0)
        {
            vel_2 = vel / 2;
        }
        else
        {
            vel_2 = vel;
        }

        moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection * vel_2);

        //////////////ANIMAÇÃO///////////////
        if (moveZ != 0)
        {
            an.CrossFade("Andar");
        }
        else
        {
            an.CrossFade("Idle");
        }
        


        ////////////////////PULINHO SALTITANTE////////////////////////////

        if (controller.isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                moveY = alturaDoPulo;
            }
        }
        moveY -= gravidade * Time.deltaTime;

        moveDirection.y = moveY;


        //////////////////MOVIMENTAÇÃO GERAL//////////////////////////
        controller.Move(moveDirection * Time.deltaTime);


        
        //////////OLHAR PARA OS LADOS//////////////////////
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 4.0f, 0));




    }
}