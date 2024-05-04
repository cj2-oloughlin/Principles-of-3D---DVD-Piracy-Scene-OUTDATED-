using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitInChair : MonoBehaviour
{

    public GameObject chair;
    public Vector3 sitOffset = new Vector3(0f, 0.5f, 0f);
    private bool isSitting = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !isSitting)
        {
            Sit();
        }
        else if (Input.GetKeyDown(KeyCode.F) && isSitting)
        {
            Stand();
        }
    }

    void Sit()
    {
        if (chair != null)
        {
            transform.position = chair.transform.position + sitOffset;
            transform.parent = chair.transform;
            isSitting = true;
        }
    }

    void Stand()
    {
        transform.parent = null;
        isSitting = false;
    }
}