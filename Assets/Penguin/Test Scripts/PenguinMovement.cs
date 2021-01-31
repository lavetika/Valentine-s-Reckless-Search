using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PenguinMovement : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    public Text won;
    private Rigidbody2D rb;
    Vector2 input;

    bool finished = false;

    public float speed = 200f;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //audio = GetComponent<AudioSource>();
        audio = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (finished) {
            audio.volume = audio.volume - (Time.deltaTime * .15f);
        }

    }

    private void FixedUpdate() {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D other){        
        if(other.CompareTag("Fish")){                
            scoreValue += 50;
            Destroy(other.gameObject);
            score.text = "Score: " + scoreValue;
        }else if(other.CompareTag("Gema")){            
            won.text = "Congratulations! You won!";
            Destroy(other.gameObject);
            finished = true;
            StartCoroutine("MostrarFinal");            
        }
    }

    IEnumerator MostrarFinal (){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Final");
    }
}
