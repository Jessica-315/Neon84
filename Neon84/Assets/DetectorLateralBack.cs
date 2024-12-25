using UnityEngine;

public class DetectorLateralBack : MonoBehaviour
{
    public TimelinesController timeLine;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
            timeLine.PlayIntro();
    }
}
