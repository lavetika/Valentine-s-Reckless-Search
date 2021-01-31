using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    /**
     * Tiempo de espera
     */
    public float timeWait = 0f;

    /**
     * Siguiente escena 
     */
    public string scene = "";

    private float second = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeWait < second) {
            SceneManager.LoadScene(scene);
        }
        second = second + (Time.deltaTime * 1);
    }
}
