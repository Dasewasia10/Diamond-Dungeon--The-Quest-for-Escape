using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject gridObject; // Objek yang akan digunakan untuk mengisi grid
    public int gridSizeX = 7; // Ukuran grid horizontal
    public int gridSizeY = 7; // Ukuran grid vertikal
    public float gridSpacing = 1f; // Jarak antara setiap objek dalam grid

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        float objectSize = gridObject.GetComponent<Renderer>().bounds.size.x;

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                // Hitung posisi untuk setiap objek dalam grid
                Vector3 spawnPosition = new Vector3(x * (objectSize + gridSpacing), y * (objectSize + gridSpacing), 0);

                // Buat objek grid
                GameObject spawnedObject = Instantiate(gridObject, spawnPosition, Quaternion.identity);
                spawnedObject.transform.parent = transform; // Parentkan objek ke script ini
            }
        }
    }
}
