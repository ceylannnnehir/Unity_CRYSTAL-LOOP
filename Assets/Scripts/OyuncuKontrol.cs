using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public float speed = 1.0f; // hız 1 e eşit...
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private Vector3 charPos;
    [SerializeField] private GameObject _camera;
    private SpriteRenderer _renderer;





    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
        _renderer = GetComponent<SpriteRenderer>();
         
    }

    // Update is called once per frame
    void Update()
    {
        // _animator.SetFloat(name:"speed", speed);
        // _rigidbody2D.velocity = new Vector2(x:speed, y:0f); /// karakter burada harek ettiriliyor...
        charPos = new Vector3(x:charPos.x  +Input.GetAxis("Horizontal")* (speed * Time.deltaTime), charPos.y); /// karakter hızı hesaplama
        transform.position = charPos; // karakterin pozisyonunu değişkene atıp burdan oluşturuluyor...

        if (Input.GetAxis("Horizontal") == 0.0f) // yataydaki hız ayarı
        {
            _animator.SetFloat(name: "speed", value: 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", speed); // girdi değeri 0 değilse hareket etsin karakter...

        }

        if (Input.GetAxis("Horizontal") > 0.01f) // sağa giderken karakterin yüzü sağa baksın
        {
            _renderer.flipX = false;
        }
        else if(Input.GetAxis("Horizontal") < -0.01f) // sola giderken karakterin yüzü sola baksın
        {
            _renderer.flipX=true;
        }
    }

    // karakter ile kamera aynı anda hareket etmesi...
    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(charPos.x, charPos.y, z: charPos.z - 1.0f); // kamerayı biraz öteleme..
    }
}
