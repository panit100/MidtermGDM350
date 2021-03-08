using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    public Transform player;
    public Vector3 TargetOffset;
    public float MoveSpeed = 2f;
    
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    void SetTarget(Transform _transform){
        player = _transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(player != null){
            myTransform.position = Vector3.Lerp(myTransform.position,player.position + TargetOffset,MoveSpeed * Time.deltaTime);
        }
    }
}
