using UnityEngine;

public class AvatarCameraFollow : MonoBehaviour
{
    public Transform avatarTarget;  // Reference to your UMA Avatar
    public Vector3 offset = new Vector3(0, 1.5f, 2f);

    void LateUpdate()
    {
        if (avatarTarget != null)
        {
            // Set camera position relative to avatar
            transform.position = avatarTarget.position + offset;

            // Always look directly at avatar
            transform.LookAt(avatarTarget.position + Vector3.up * 1.5f);
        }
    }
}