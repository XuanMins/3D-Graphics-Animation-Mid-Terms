using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    /* can see the variable in the Inspector, but 
    it's not actually publicly accessible from 
    outside the script **/
    [SerializeField]
    float movementSpeed;
    
    [SerializeField]
    float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetAxisRaw = stops instantly
        float movement = Input.GetAxisRaw("Vertical");
        float turn = Input.GetAxis("Horizontal");
        

        transform.Translate(new Vector3(0, 0, movement) * movementSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, turn, 0) * rotateSpeed * Time.deltaTime);
    }

}
