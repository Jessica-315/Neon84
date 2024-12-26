using UnityEngine;

public class DetectorLateralBack : MonoBehaviour
{
    public TimelinesController timeLine;

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            timeLine.PlayIntro();
    }
}
