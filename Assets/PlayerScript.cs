using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : Singleton<PlayerScript>
{
    public float speed = 2;
    public float maxVelocity = 15;
    public float maxSpin = 20;
    public float spinSpeed = 0.1f;
    Rigidbody2D body;
    public float currentSpinSpeedPercent = 0;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Vector2 localVelocity = transform.InverseTransformDirection(body.velocity);
        if (Input.GetKey(KeyCode.W) && (localVelocity.y < maxVelocity))
        {
            body.AddForce(gameObject.transform.up * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S) && (-1 * localVelocity.y < maxVelocity))
        {
            body.AddForce(-1 * gameObject.transform.up * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.E) && (localVelocity.x < maxVelocity * 0.5))
        {
            body.AddForce(gameObject.transform.right * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.Q) && (-1 * localVelocity.x < maxVelocity * 0.5))
        {
            body.AddForce(-1 * gameObject.transform.right * speed, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A) && body.angularVelocity < maxSpin)
        {
            if (body.angularVelocity < 0)
            {
                currentSpinSpeedPercent = 0.1f;
              //  body.angularVelocity = 0;
            }
            currentSpinSpeedPercent += 0.01f;
           
            body.AddTorque(Mathf.Lerp(0, spinSpeed, currentSpinSpeedPercent), ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.D) && -1 * body.angularVelocity < maxSpin)
        {
            if(body.angularVelocity >0)
            {
                currentSpinSpeedPercent = 0.1f;
             //   body.angularVelocity = 0;
            }
            currentSpinSpeedPercent += 0.01f;
            body.AddTorque(-Mathf.Lerp(0, spinSpeed, currentSpinSpeedPercent), ForceMode2D.Impulse);
        }

        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {

            currentSpinSpeedPercent = 0.1f;
        }
      //  Debug.Log("currentSpinSpeedPercent: " +currentSpinSpeedPercent + "angularVelocity: " + body.angularVelocity);
    }

















    // Update is called once per frame
    //void Update()
    //{
    //    Flipping();
    //    Vector2 localVelocity = transform.InverseTransformDirection(body.velocity);

    //    bool isDirectionRight = Input.GetKey(KeyCode.D) && !flipped || (Input.GetKey(KeyCode.A) && flipped);
    //    bool isDirectionLeft = Input.GetKey(KeyCode.A) && !flipped || (Input.GetKey(KeyCode.D) && flipped);
    //    if (isDirectionRight && ((!flipped && (localVelocity.x < maxVelocity)) || flipped && (localVelocity.x < maxVelocity*0.5)))
    //    {
    //        body.AddForce(gameObject.transform.right * speed, ForceMode2D.Impulse);
    //    }
    //    if (isDirectionLeft && ((flipped && (-1*localVelocity.x < maxVelocity)) || !flipped && (-1*localVelocity.x < maxVelocity * 0.5)))
    //    {
    //        body.AddForce(-1 * gameObject.transform.right * speed, ForceMode2D.Impulse);
    //    }
    //    if (Input.GetKey(KeyCode.Q) && body.angularVelocity < maxSpin)
    //    {
    //        body.AddTorque(spinSpeed, ForceMode2D.Impulse);
    //    }
    //    if (Input.GetKey(KeyCode.E) && -1 * body.angularVelocity < maxSpin)
    //    {
    //        body.AddTorque(-spinSpeed, ForceMode2D.Impulse);
    //    }
    //}
    //    private void Flipping()
    //    {
    //        if (transform.rotation.eulerAngles.z < 270 && transform.rotation.eulerAngles.z > 90)
    //        {
    //            transform.localScale = new Vector3(transform.localScale.x, -1, transform.localScale.z);
    //            flipped = true;
    //        }
    //        else
    //        {
    //            transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
    //            flipped = false;
    //        }
    //    }
}
