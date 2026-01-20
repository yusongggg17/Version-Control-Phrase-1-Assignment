using UnityEngine;
using System.Collections;

public class TockenManager : MonoBehaviour
{
    public GameObject FinalPlatform;
    public int totalToken;
    private int currentToken;
    private void Awake()
    {
        currentToken = 0;
    }
    public void collectedToken() {
        currentToken++;
        if (currentToken >= totalToken)
        {
            FinalPlatform.gameObject.SetActive(false);
            StartCoroutine(LoadNextScene());

        }
    }

    IEnumerator LoadNextScene() {
        yield return new WaitForSeconds(1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Testlevel2");
    }
}
