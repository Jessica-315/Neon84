using Cinemachine;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UIManager manager;
    public float speed;

    private float inputVertical;
    private float inputHorizontal;
    private bool directionPlayerLateralCamera;
    private bool gameplayReady;
    private bool lateral; // True: lateral, False: back

    private Animator characterAnimator;
    private Rigidbody characterRigidBody;


    public CinemachineVirtualCamera cameraLateral;
    public CinemachineVirtualCamera cameraBack;

    private void Start()
    {
        characterAnimator = GetComponent<Animator>();
        characterRigidBody = GetComponent<Rigidbody>();
        directionPlayerLateralCamera = false;
        gameplayReady = true;
        lateral = true;
        if (characterAnimator == null)
        {
            Debug.LogError("No se encontró un Animator en este GameObject o sus hijos.");
        }
    }

    void Update()
    {

        if (!gameplayReady)
            return;

        inputVertical = Input.GetAxis("Vertical");

        if (inputVertical > 0)
        {
            transform.Translate(Vector3.forward *
                            speed *
                            inputVertical * Time.deltaTime);
        }
        characterAnimator.SetFloat("Speed",
                                    inputVertical);

        if (lateral)
            LateralCamera();
        else
            BackCamera();




        /*characterAnimator.SetFloat("Direction",
                                    inputHorizontal);
        */

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


    private void BackCamera()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *
                            speed *
                            inputHorizontal * Time.deltaTime);
    }

    private void LateralCamera()
    {

        if (Input.GetKeyDown(KeyCode.D) && directionPlayerLateralCamera)
        {
            transform.Rotate(Vector3.up * 180);
            directionPlayerLateralCamera = false;
        }

        if (Input.GetKeyDown(KeyCode.A) && !directionPlayerLateralCamera)
        {
            transform.Rotate(Vector3.up * 180);
            directionPlayerLateralCamera = true;
        }
        
    }

    public void ActivateGameplay()
    {
        gameplayReady = true;
    }

    public void DesactivateGameplay()
    {
        gameplayReady = false;
    }

    public void ActivateIntro()
    {
        characterAnimator.SetBool("Intro",
                                    true);
    }

    public void DesactivateIntro()
    {
        characterAnimator.SetBool("EndIntro",
                                    true);
        characterAnimator.SetBool("Intro",
                                    false);
        lateral = true;
        cameraLateral.Priority = 10;
    }

    public void ActivateLateral()
    {
        lateral = true;
        cameraLateral.Priority = 10;
        cameraBack.Priority = 8;
    }

    public void ActivateBack()
    {
        lateral = false;
        cameraLateral.Priority = 8;
        cameraBack.Priority = 10;
    }


}
