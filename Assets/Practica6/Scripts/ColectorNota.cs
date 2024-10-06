using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ColectorNota : MonoBehaviour
{
   
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI cont1;
    [SerializeField] TextMeshProUGUI mnsj;
    public int contador;
    void Start()
    {
        contador = 0;
        cont1.text = contador.ToString();//actualiza el texto al inicio
    }

    // Update is called once per frame
   private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        
        if (objeto.CompareTag("Nota")){
            Destroy(objeto);
            contador++;
            cont1.text = contador.ToString();
           
        }
         if(contador >=8){
                insertMnsj("Has Ganado :) ");
            }
    }

    public void insertMnsj(String Labelmnsj){
        mnsj.text = (Labelmnsj);
       
    }
}
