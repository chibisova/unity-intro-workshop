using UnityEngine;

// Prepared for the workshop - you don't need to edit this.
// Keeps the camera at a fixed offset behind the target and looks at it.
public class CameraFollow : MonoBehaviour
{
    public Transform target;   // leave empty: the camera finds the Player by itself
    public Vector3 offset = new Vector3(0f, 6f, -8f);
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        // No target yet? Look for the Player (it has the PlayerAnimation script on it)
        if (target == null)
        {
            PlayerAnimation player = FindAnyObjectByType<PlayerAnimation>();
            if (player == null) return;
            target = player.transform;
        }

        Vector3 desired = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desired, smoothSpeed * Time.deltaTime);
        transform.LookAt(target.position + Vector3.up);
    }
}
