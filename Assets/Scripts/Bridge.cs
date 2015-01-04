using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour
{
    bool rotated;
    public void triggerBridge()
    {
        if (rotated)
        {
            transform.Rotate(new Vector3(0f, 0f, -90f));
        } else
        {
            transform.Rotate(new Vector3(0f, 0f, 90f));
        }
        rotated = !rotated;
    }
}
