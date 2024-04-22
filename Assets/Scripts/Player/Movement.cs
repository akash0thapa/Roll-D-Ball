using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
 public float speed;
    public Rigidbody rb;
    public float forwardForce=1000f;
    public float sideForce=1500f;
    public SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        //controller=GetComponent<CharacterController>();
        rb=GetComponent<Rigidbody>();
        rb.AddForce(0,-100,0);
       
        
    }
    void FixedUpdate()
    {
        if(!PlayerManager.GameStart)
        return;
        //controller.Move(direction*Time.fixedDeltaTime);
        rb.AddForce(0, 0,forwardForce*Time.fixedDeltaTime);
        speed=rb.velocity.magnitude;
        if(Input.GetKey("a")||Input.GetKey (KeyCode.LeftArrow)){
            rb.AddForce(-sideForce*Time.fixedDeltaTime,0, 0);
        }
        if(Input.GetKey("d")||Input.GetKey (KeyCode.RightArrow)){
            rb.AddForce(sideForce*Time.fixedDeltaTime,0, 0);
        } 
        if(Input.GetKey("s")||Input.GetKey (KeyCode.DownArrow)){
            rb.AddForce(0,-sideForce*Time.fixedDeltaTime,0);
        } 


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="SpawnTrigger")
        spawnManager.SpawnTriggerEntered();
    }
    public void OnCollisionEnter(Collision other)
    {
    if (other.gameObject.tag=="obstacle"){
        PlayerManager.GameOver=true;
        FindObjectOfType<AudioManager>().PlaySound("GameOver");
    }
    }
}
