using UnityEngine;

public class fan : MonoBehaviour
{
   
    //
    void Update()
    {
        transform.Rotate(Vector3.up, 40 * Time.deltaTime);
    }
}
