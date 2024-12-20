using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UIManager manager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            manager.ShowPause();
        }

        if (Input.GetMouseButton(0))
        {
            //this.gameObject.SendMessage("PlayEFx", 0);
            AudioManager.Instance.PlaySoundById(0);
        }
    }
}
