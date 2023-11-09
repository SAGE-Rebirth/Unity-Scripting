using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator anim;

    private Rigidbody rb;

    private CharacterController character_controller; 
    public float speed = 3f, gravity = -10f, jumpForce = 10f;
    private Vector3 playerinput, velocity;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       character_controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
       Move();
    }

    void Move()
    {
       playerinput = Vector3.zero;
       playerinput += transform.forward * Input.GetAxis("Vertical");
       playerinput += transform.right * Input.GetAxis("Horizontal");

      if (character_controller.isGrounded){
         velocity.y = -1f;
         if(Input.GetKey(KeyCode.Space)){
            anim.SetTrigger("Jump");
            velocity.y = jumpForce;
         }
         else{
            velocity.y -= gravity * -1 * Time.deltaTime;
         }
      }

       character_controller.Move(playerinput * speed * Time.deltaTime);
       character_controller.Move(velocity * Time.deltaTime);
       anim.SetFloat("X", Input.GetAxis("Horizontal"));
       anim.SetFloat("Y", Input.GetAxis("Vertical"));
    }
}
