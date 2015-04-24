using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float _speed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private Animator anim;
	private ParallaxController parallaxController;


	void Start () {
		anim = GetComponent<Animator> ();	
		parallaxController = GetComponent<ParallaxController> ();
	}

	void FixedUpdate()
	{

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.position -= new Vector3 (_speed * Time.deltaTime, 0.0f, 0f);
			parallaxController.Scroll(Vector2.right);
			//anim.Play("walking");
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.position += new Vector3 (_speed * Time.deltaTime, 0.0f, 0.0f);
			parallaxController.Scroll(-Vector2.right);
			//anim.Play("walking");
		}
		if (Input.GetKeyDown (KeyCode.Space) && grounded) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
			//anim.Play("Jump");
		}
	}
	
}
