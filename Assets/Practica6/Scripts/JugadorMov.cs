using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMov : MonoBehaviour
{
    [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }
       void Update()
    {   //arriba - abajo
        if(Input.GetKey(KeyCode.W)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }   else if(Input.GetKey(KeyCode.S)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
            
        }
            //izquierda derecha 
         if(Input.GetKey(KeyCode.A)){
            transform.position += velocidad_movimiento * -1* Time.deltaTime * transform.right;
        }   else if(Input.GetKey(KeyCode.D)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;            
        }
            //rotar izquierda - rotar derecha
         if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime, 0);
        }   else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime, 0);
        }
    }
}    
