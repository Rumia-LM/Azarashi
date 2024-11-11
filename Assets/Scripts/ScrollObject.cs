using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed=1.0f;
    public float startPosition;
    public float endPosition;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1*speed*Time.deltaTime,0,0);
        if(transform.position.x<=endPosition) ScrollEnd();     
    }

    void ScrollEnd(){
        float diff = transform.position.x-endPosition;
        Vector3 restartPosotion=transform.position;
        restartPosotion.x=startPosition+diff;
        transform.position=restartPosotion;
        SendMessage("OnScrollEnd",SendMessageOptions.DontRequireReceiver);
    }
}
