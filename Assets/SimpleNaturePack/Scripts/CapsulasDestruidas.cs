using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class CapsulasDestruidas : MonoBehaviour
{
    public int contador_enemigo;
    [SerializeField] TextMeshProUGUI contadorenemigo;
    // Start is called before the first frame update
    void Start()
    {
     contador_enemigo=0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Puntos")){
            Destroy(obj);
            contador_enemigo++;
            //Debug.Log("enemigos: "+contador_enemigo);
            contadorenemigo.text=contador_enemigo.ToString();
        }
    }
}
