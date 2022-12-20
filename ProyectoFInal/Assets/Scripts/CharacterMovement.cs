using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float Speed = 2f;
    public Animator anim;
    void Update()
    {
        MovimientoJugador();

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Running",true);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Running",false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jumping",true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("Jumping",false);
        }


    }


    void MovimientoJugador()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * Speed);
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-0.5f,0);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,0.5f,0);
        }
    }
}
