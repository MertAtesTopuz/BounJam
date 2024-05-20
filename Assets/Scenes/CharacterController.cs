using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    #region Movement & Physic
    public static CharacterController instance;

    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    public bool consoleCheck;

    private bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask, plankLayer;

    private Rigidbody rb;
    private bool movement = true;
    private AudioSource walkAudioSource;
    private AudioSource jumpAudioSource;
    #endregion

    #region Health
    public bool isAlive = true;
    #endregion

    private Scene currentScene;

    private void Awake()
    {
        instance = this;
        // Get the AudioSource components
        AudioSource[] audioSources = GetComponents<AudioSource>();
        walkAudioSource = audioSources[0];
        jumpAudioSource = audioSources[1];
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        Debug.Log(isGrounded);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movement = FindAnyObjectByType<log>().canMove;

        if (consoleCheck == false && movement == true)
        {
            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

            transform.Translate(movement);

            // Play walking sound if moving and grounded
            if ((horizontalInput != 0 || verticalInput != 0) && isGrounded)
            {
                if (!walkAudioSource.isPlaying)
                {
                    walkAudioSource.Play();
                }
            }
            else
            {
                walkAudioSource.Stop();
            }

            // Play jumping sound if space is pressed
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jumpAudioSource.Play();
            }
        }
        else
        {
            walkAudioSource.Stop();
            return;
        }

        isDead();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(groundCheck.position, groundDistance);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void isDead()
    {
        if (isAlive == false)
        {
            isAlive = true;

            SceneManager.LoadScene(1);
        }
    }
}