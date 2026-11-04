using UnityEngine;
using UnityEngine.SceneManagement;

public class tombolselanjutnya : MonoBehaviour
{
    public string namaSceneTujuan;

    public void PindahScene()
    {
        SceneManager.LoadScene(namaSceneTujuan);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SceneHome");
        }
    }
}