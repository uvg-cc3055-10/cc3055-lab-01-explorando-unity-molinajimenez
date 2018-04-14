using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float JumpForce;
    public Rigidbody2D referencia;
    public float forwardSpeed=5f;
    public GameObject cam;
    public bool dead=false;
    // Use this for initialization
    void Start () {
        referencia = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision){
        dead = true;    

    }


    // Update is called once per frame
    void Update () {
        if (dead == false){
            referencia.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            if (Input.GetButtonDown("Jump")){
                referencia.velocity = Vector2.zero;
                Debug.Log("Espacio");
                referencia.AddForce(new Vector2(0, 1) * JumpForce);
            }
            if(referencia.transform.position.x>= 10.34143){
                dead = true;
            }
        }
    }
}
