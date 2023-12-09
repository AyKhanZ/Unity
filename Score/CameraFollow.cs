using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public Vector3 point;

    public float smoothtime;

    public Transform LeftBorder;
    
    public Transform RightBorder;
    
    public Transform TopBorder;

    public Transform BottomBorder;

    void FixedUpdate()
    {
        Following();

        Limit(); 
    }

    private void Limit()
    {
        transform.position = new Vector3
        (
            // Mathf.Clamp - diapazone
            Mathf.Clamp(transform.position.x, LeftBorder.position.x, RightBorder.position.x),
            Mathf.Clamp(transform.position.y, BottomBorder.position.y, TopBorder.position.y),
            Mathf.Clamp(transform.position.z, -50, -50)
        );
    }
    private void Following()
    {
        point.x = player.position.x;

        point.y = player.position.y;

        point.z = -20;

        Vector3 point_possition = Vector3.Lerp(transform.position, point, smoothtime * Time.fixedDeltaTime);

        transform.position = point_possition;
    }
}
