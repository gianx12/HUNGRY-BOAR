using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    public Transform mainCam;
    public Transform middleBG;
    public Transform sideBG;
    public float length = 39.8f;

    // Update is called once per frame
    void Update()
    {
        if(mainCam.position.x > middleBG.position.x)
        {
            sideBG.position = middleBG.position + Vector3.right * length;
        } else
        {
            sideBG.position = middleBG.position + Vector3.left * length;
        }

        if(mainCam.position.x > sideBG.position.x || mainCam.position.x < sideBG.position.x)
        {
            Transform temp = middleBG;
            middleBG = sideBG;
            sideBG = temp;
        }
    }
}
