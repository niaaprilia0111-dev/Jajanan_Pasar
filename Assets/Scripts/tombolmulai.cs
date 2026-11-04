using UnityEngine;
using UnityEngine.SceneManagement;

public class gabungan : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) ||
            Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}