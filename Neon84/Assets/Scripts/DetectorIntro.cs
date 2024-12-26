using UnityEngine;

public class DetectorIntro : MonoBehaviour
{
    public TimelinesController timeLine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
            timeLine.PlayIntro();
    }
}
