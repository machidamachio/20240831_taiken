using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog_Polyart_1 : MonoBehaviour
{
    public Rigidbody rb;
    public int movie_rf = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //前
        if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-1.2f,0,0);
        }
        //左
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0,0,-2*movie_rf);
        }
        //後ろ
        if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            rb.AddForce(1.2f,0,0);
        }
        //右
        if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0,0,2*movie_rf);
        }

        if(this.transform.position.y < -20)
        {
            this.transform.position = new Vector3(-3, 0.1f, 0);
            rb.velocity = Vector3.zero;
        }
    }


void OnTriggerEnter(Collider collision)
{
            if(collision.gameObject.tag == "trap1")
        {
            Debug.Log("trap作動");

            movie_rf = movie_rf* -1;
        }
}
}
