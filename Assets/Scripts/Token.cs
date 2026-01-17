using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Token : MonoBehaviour
{
    public TockenManager tokenManager;
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    private void Update()
    {
        this.gameObject.transform.Rotate(0,0,-0.5f,Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tokenManager.collectedToken();
            this.gameObject.SetActive(false);
        }
    }
}
