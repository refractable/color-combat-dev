using UnityEngine;

public class NeckLookat : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        if (target != null)
        {
            // Make the object look at the target object
            transform.LookAt(target);
        }
    }
}
