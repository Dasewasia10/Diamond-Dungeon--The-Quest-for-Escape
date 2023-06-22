using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 5f;
    private int currentWaypointIndex = 0;

    private void Update()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform targetWaypoint = waypoints[currentWaypointIndex];
            Vector3 moveDirection = targetWaypoint.position - transform.position;

            if (moveDirection.magnitude < 0.1f)
            {
                currentWaypointIndex++;
            }
            else
            {
                // Menggerakkan pemain menggunakan tombol panah
                float horizontalInput = Input.GetAxis("Horizontal");
                float verticalInput = Input.GetAxis("Vertical");

                Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput);
                Vector3 movement = inputDirection.normalized * moveSpeed * Time.deltaTime;
                transform.Translate(movement, Space.World);
            }
        }
    }
}
