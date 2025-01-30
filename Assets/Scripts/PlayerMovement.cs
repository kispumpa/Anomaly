using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Camera jatekosKamera;
    public float setaSebesseg = 4f;
    public float futasSebesseg = 12f;
    public float ugrasEro = 2f;
    public float gravitacio = 10f;
    static public float nezelodesSebesseg = 1f;
    public float nezesXLimit = 45f;
    public float alapMagassag = 2f;
    public float guggoloMagassag = 1f;
    public float guggoloSebesseg = 3f;
    public GameObject startPanel;
    public Animator anim;
    public Image kep;
    public GameObject fadeEgesz;
    public GameObject screenDot;
    public static bool motva = false;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;


    private bool tudMozogni = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool futE = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = tudMozogni ? (futE ? futasSebesseg : setaSebesseg) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = tudMozogni ? (futE ? futasSebesseg : setaSebesseg) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && tudMozogni && characterController.isGrounded)
        {
            moveDirection.y = ugrasEro;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (Input.GetKey(KeyCode.Escape) && motva == false )
        {
            startPanel.SetActive(false);
            kep.enabled = true;
            anim.SetBool("isClicked", true);
            screenDot.SetActive(true);
            motva = true;
        }
       
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravitacio * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.G) && tudMozogni)
        {
            characterController.height = guggoloMagassag;
            setaSebesseg = guggoloSebesseg;
            futasSebesseg = guggoloSebesseg;

        }
        else
        {
            characterController.height = alapMagassag;
            setaSebesseg = 4f;
            futasSebesseg = 12f;
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (tudMozogni)
        {
            rotationX += -Input.GetAxis("Mouse Y") * nezelodesSebesseg;
            rotationX = Mathf.Clamp(rotationX, -nezesXLimit, nezesXLimit);
            jatekosKamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * nezelodesSebesseg, 0);
        }
    }
}
