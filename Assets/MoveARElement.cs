using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveARElement : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0, y);
        rigidBody.velocity =  move * 3f;   
    }
}
