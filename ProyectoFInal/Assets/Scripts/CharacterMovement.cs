using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float Speed = 2f;
    
    void Update()
    {
        MovimientoJugador();
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
