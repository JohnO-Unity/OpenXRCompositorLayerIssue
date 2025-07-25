using UnityEngine;
using System.Collections;

public class CubeRotator : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(RotateCube());
    }

    private IEnumerator RotateCube()
    {
        while (true)
        {
            // Calculate how much to rotate each frame for one complete rotation (360 degrees) over 5 seconds
            float rotationPerSecond = 360f / 5f;
            
            // Rotate around the Y axis
            transform.Rotate(Vector3.up, rotationPerSecond * Time.deltaTime);
            
            yield return null;
        }
    }
}