using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour {

    void OnCollisionEnter(Collision collision){
    // pregunto si en este objeto le pego o colisino contra el objeto que tiene el tag en el Carro
    if (collision.gameObject.tag=="Carro") {

    // En La consola de Unity aparece que perdí
      Debug.Log ("Game Over");
           SceneManager.LoadScene("My Project");

       }
        
    }
}
