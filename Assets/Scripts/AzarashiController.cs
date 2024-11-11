using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzarashiController : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    float angle;

    public float maxHeight;
    public float flapVelocity;
    public float relativeVelocityX;
    public GameObject sprite;

    void Awake(){
        rb2d=GetComponent<Rigidbody2D>();
        animator=sprite.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && transform.position.y<maxHeight){
            Flap();
        }

        ApplyAngle();
        animator.SetBool("flap", angle>=0.0f);
    }

    public void Flap(){
        rb2d.velocity=new Vector2(0.0f, flapVelocity);
    }

    void ApplyAngle(){
        float targetAngle=Mathf.Atan2(rb2d.velocity.y, relativeVelocityX)*Mathf.Rad2Deg;
        angle =Mathf.Lerp(angle, targetAngle, Time.deltaTime*10.0f);
        sprite.transform.localRotation=Quaternion.Euler(0.0f, 0.0f, angle);
    }
}
