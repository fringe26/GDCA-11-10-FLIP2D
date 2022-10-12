using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _bulletForce = 5f;
    private float _bulletDamage=5f;
    private PlayerController _playerController;
    private bool _isRight=false;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _isRight = _playerController.IsRight();
        if (_isRight)
        {
            Debug.Log("RIght!");
            _rb.AddForce(Vector2.right * _bulletForce, ForceMode2D.Impulse);
        }
        else
        {
            _rb.AddForce(Vector2.left * _bulletForce, ForceMode2D.Impulse);
        }
        
        Destroy(gameObject,2f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("EnemyBox"))
        {
            Debug.Log("Bullet touched EnemyBox");
            other.transform.GetComponent<EnemyBoxScript>().GetDamage(_bulletDamage);
            Destroy(gameObject);
        }
    }
}
