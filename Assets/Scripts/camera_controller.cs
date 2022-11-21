using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    [SerializeField]
    Transform targetTransform;

    [SerializeField]
    float miny,maxy;

    Vector2 lastpos;

    [SerializeField]
    Transform bgmain, bg;

   
    private void Start()
    {
        lastpos = transform.position; 
    }
  
    private void Update()
    {
        clampCameraFNC();
        backgroundmoveFNC();    
    }

    void clampCameraFNC()
    {

        transform.position = new Vector3(targetTransform.position.x, Mathf.Clamp(targetTransform.position.y, miny, maxy), transform.position.z);
    }

    void backgroundmoveFNC()
    {
        Vector2 betweenvalue = new Vector2(transform.position.x - lastpos.x, transform.position.y - lastpos.y);

        bgmain.position += new Vector3(betweenvalue.x, betweenvalue.y, 0f);
        bg.position += new Vector3(betweenvalue.x, betweenvalue.y, 0f)*0.5f;

        lastpos=transform.position;
    }

    
}
