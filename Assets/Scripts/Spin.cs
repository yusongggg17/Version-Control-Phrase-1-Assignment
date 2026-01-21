using UnityEngine;

public class Spin : MonoBehaviour
{
    private void Update()
    {
        this.gameObject.transform.Rotate(0, 0, -0.5f, Space.Self);
    }

}
