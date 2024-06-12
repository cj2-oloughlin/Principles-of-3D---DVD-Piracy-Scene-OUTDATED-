using UnityEngine;

public class SitInChair : MonoBehaviour
{

    [SerializeField] private GameObject screen;
    [SerializeField] private Player player;
    [SerializeField] private Transform playerCamera;

    [SerializeField] private Vector3 sittingPosition = new Vector3(0f, 0.5f, 0f);
    [SerializeField] private Quaternion sittingRotation;
    [SerializeField] private Vector3 sittingScale = new Vector3(0f, 0.5f, 0f);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !player.isSitting) Sit();
        else if (Input.GetKeyDown(KeyCode.F) && player.isSitting) Stand();
    }

    void Sit()
    {
        player.transform.parent = transform;
        player.transform.localPosition = sittingPosition;
        player.transform.localRotation = sittingRotation;
        player.transform.localScale = sittingScale;
        playerCamera.LookAt(screen.transform);
        player.isSitting = true;
    }

    void Stand()
    {
        player.transform.parent = null;
        player.isSitting = false;
    }
}