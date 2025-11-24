using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol2 : MonoBehaviour
{
    public float jumpForce = 2.0f; // zıplama gücü
    public float speed = 1.0f;     // hız
    private float moveDirection;
    public bool jump;
    public bool grounded = true;
    public bool moving;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _renderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // Hareket var mı yok mu?
        moving = _rigidbody.velocity != Vector2.zero;

        // Hareket yönü
        _rigidbody.velocity = new Vector2(speed * moveDirection, _rigidbody.velocity.y);

        // Zıplama
        if (jump == true)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
            jump = false;
            Debug.Log("Zıplama yapıldı!");
        }
    }

    void Update()
    {
        // TEST logu
        Debug.Log("Grounded: " + grounded + " | Velocity: " + _rigidbody.velocity);

        // Hareket (sol/sağ)
        if (grounded == true && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection = -1.0f;
                _renderer.flipX = true;
                _animator.SetFloat("speed", speed);
                Debug.Log("Sola hareket");
            }
            else if (Input.GetKey(KeyCode.D))
            {
                moveDirection = 1.0f;
                _renderer.flipX = false;
                _animator.SetFloat("speed", speed);
                Debug.Log("Sağa hareket");
            }
        }
        else if (grounded == true)
        {
            moveDirection = 0.0f;
            _animator.SetFloat("speed", 0.0f);
        }

        // Zıplama
        if (grounded == true && Input.GetKey(KeyCode.W))
        {
            jump = true;
            grounded = false;
            _animator.SetTrigger("jump");
            _animator.SetBool("grounded", false);
            Debug.Log("Zıplama tuşuna basıldı");
        }
    }

    // Zemine çarpınca
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Çarptığım tag: " + col.gameObject.tag);
        if (col.gameObject.tag == "Zemin")
        {
            grounded = true;
            _animator.SetBool("grounded", true);
            Debug.Log("Yere değdim (OnCollisionEnter2D)");
        }
    }

    // Zeminde kalmaya devam ederken
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            grounded = true;
        }
    }

    // Zeminden ayrılınca
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            grounded = false;
            Debug.Log("Yerden ayrıldım");
        }
    }
}
