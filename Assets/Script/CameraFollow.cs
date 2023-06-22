using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objek yang ingin diikuti

    public float smoothSpeed = 0.125f; // Kecepatan pergerakan kamera
    public Vector3 offset; // Jarak antara kamera dan objek target

    private void FixedUpdate()
    {
        // Menghitung posisi yang ingin dituju oleh kamera
        Vector3 desiredPosition = target.position + offset;

        // Menggunakan fungsi SmoothDamp untuk menghaluskan pergerakan kamera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Mengatur posisi kamera sesuai dengan posisi yang telah dihaluskan
        transform.position = smoothedPosition;
    }
}
