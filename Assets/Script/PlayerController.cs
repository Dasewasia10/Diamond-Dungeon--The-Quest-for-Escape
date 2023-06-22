using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject startPrefab;
    private GameObject playerObject;

    private void Start()
    {
        if (startPrefab != null)
        {
            // Membuat objek pemain
            playerObject = Instantiate(startPrefab);
            transform.position = playerObject.transform.position + new Vector3(0, 1f, 0);
        }
        else
        {
            Debug.LogError("Prefab start belum diatur pada PlayerController!");
        }
    }

    private void Update()
    {
        // Menggerakkan pemain
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
