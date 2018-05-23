using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    public float jumpPower;
    private Rigidbody ribo;

    RaycastHit hit;

    public bool isGoal;
    public bool isGameOver;

    //test



	void Start () {
        isGoal = false;
        isGameOver = false;
        ribo = gameObject.GetComponent<Rigidbody>();
	}

	void Update () {
        if (Physics.Linecast(transform.position, new Vector3(transform.position.x, transform.position.y - 0.51f, transform.position.z), out hit, LayerMask.GetMask("Stage", "Ground")))
        {
            Move();
            Jump();
            if(hit.collider.gameObject.name == "Goal")
            {
                isGoal = true;
            }
            if(hit.collider.gameObject.name == "Ground")
            {
                isGameOver = true;
            }
        }
	}

    private void Move()
    {
       float directionV = Input.GetAxisRaw("Vertical");
       float directionH = Input.GetAxisRaw("Horizontal");

        ribo.velocity = new Vector3(directionH, 0, directionV) * moveSpeed;

        if(directionH == 0 && directionV ==0)
        {
            ribo.velocity = Vector3.zero;
        }

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ribo.AddForce(Vector3.up * jumpPower);
        }
    }
}
