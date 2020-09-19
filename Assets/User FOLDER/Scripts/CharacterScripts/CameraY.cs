using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraY : MonoBehaviour
{

    float speedY = 100;
    float limitY = 3;
    float currentYRotation;

    // Start is called before the first frame update
    void Start()
    {
        // var cam = GetComponent<CinemachineVirtualCamera>();
        // cam.
    
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    void CameraRotation()
    {
        var my = Input.GetAxis("Mouse Y");
        if (my != 0)
        {
            var tmp = Mathf.Clamp(currentYRotation + my * speedY * Time.deltaTime, -limitY, limitY);
            if (tmp != currentYRotation)
            {
                var rot = tmp - currentYRotation;
                transform.position = new Vector3(transform.position.x,transform.position.y + rot,transform.position.z);
                currentYRotation = tmp;
                //cam.
                Debug.Log(rot);
            }
        }
    }
}
