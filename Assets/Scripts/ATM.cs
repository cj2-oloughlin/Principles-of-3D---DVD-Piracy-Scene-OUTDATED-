using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] Vector3 scale;
    public Vector3 spawnOffset = Vector3.zero;
    public Vector3 colliderSize = new Vector3(1f, 1f, 1f);


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        if (objectToSpawn != null)
        {
            Vector3 spawnPosition = transform.position + spawnOffset;
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            Rigidbody rb = spawnedObject.AddComponent<Rigidbody>();
            rb.useGravity = true;
            BoxCollider collider = spawnedObject.AddComponent<BoxCollider>();
            collider.size = colliderSize;
        }
    }
}