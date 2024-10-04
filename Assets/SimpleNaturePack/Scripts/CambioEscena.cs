using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    int contador_enemigo;
    int escenaactiva;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // escenaactiva=SceneManager.GetActiveScene().buildIndex;
        // for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        // {
        //     if(Input.GetKeyDown(KeyCode.C)){
        //         cambiodeEscena(i);
        //     }
        // }
        if (escenaactiva == 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {

                cambiodeEscena(1, contador_enemigo);
            }
        }
    }

    //hacer que cuando este en escena 1 pase a la 2



    public void cambiodeEscena(int index, int contador_enemigo)
    {
        SceneManager.LoadScene(index);
        PlayerPrefs.SetInt("contador_enemigo", contador_enemigo);
    }
}
