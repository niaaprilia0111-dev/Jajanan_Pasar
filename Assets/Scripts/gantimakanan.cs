using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiMakanan : MonoBehaviour
{
    public GameObject[] makanan;
    public GameObject[] judul;

    private int index = 0;
    private Vector3[] posisiAwal;

    void Start()
    {
        posisiAwal = new Vector3[makanan.Length];

        for (int i = 0; i < makanan.Length; i++)
        {
            if (makanan[i] != null)
            {
                posisiAwal[i] = makanan[i].transform.localPosition;
            }
        }

        TampilkanMakanan();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) ||
            Input.GetKeyDown(KeyCode.Return))
        {
            index++;

            if (index >= makanan.Length)
            {
                SceneManager.LoadScene("SceneLama/SceneSelesai");
                return;
            }

            TampilkanMakanan();
        }
    }

    void TampilkanMakanan()
    {
        for (int i = 0; i < makanan.Length; i++)
        {
            if (makanan[i] != null)
            {
                makanan[i].SetActive(i == index);
                makanan[i].transform.localPosition = posisiAwal[i];
            }
        }

        for (int i = 0; i < judul.Length; i++)
        {
            if (judul[i] != null)
            {
                judul[i].SetActive(i == index);
            }
        }
    }
}