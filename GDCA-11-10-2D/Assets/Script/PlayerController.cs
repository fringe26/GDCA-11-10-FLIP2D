using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    [Range(1,10)]
    [SerializeField] private float _speed;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bullet;
    private float _nextAttackTime;
    [SerializeField] private float _nextAttackRate;
    [SerializeField] private float _second;

    private bool _facingRight = true;
  
    private void Update()
    {

        
        
        _horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_horizontal * _speed, 0, 0) * Time.deltaTime;
        if(!_facingRight && _horizontal > 0)
        {
            TurnFace();
        }
        else if (_facingRight && _horizontal < 0)
        {
            TurnFace();
        }

        if (Input.GetMouseButton(0))
        {
            if (Time.time>=_nextAttackTime)
            {
                Instantiate(_bullet, _firePoint.position, Quaternion.identity);
                //Debug.Log("Time.Time = "+ Time.time );
                _nextAttackTime = Time.time + _second / _nextAttackRate;
                //Debug.Log("NextAtackTime = " + _nextAttackTime);
            }
            //Debug.Log("Time.Time out of if = " + Time.time);
        }

    }

    private void TurnFace()
    {
        _facingRight = !_facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    public bool IsRight()
    {
        return _facingRight;
    }
}
