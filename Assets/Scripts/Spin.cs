using UnityEngine;

public class Spin : MonoBehaviour
{
    private void Update()
    {
        this.gameObject.transform.Rotate(0, 0, 2f, Space.Self);
    }

}
