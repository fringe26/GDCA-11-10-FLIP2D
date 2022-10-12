using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private float _horizontal;
    [Range(0, 10)] [SerializeField] private float _speed;

    private void Start()
    {
        
        
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_horizontal * _speed, 0, 0) * Time.deltaTime;
    }

    #region OnTrigger

    
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("Temas etti" + other.name);
    //}
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    Debug.Log("Cikiw etti" + other.name);
    //}
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    Debug.Log(" Icinde kaldi" + other.name);
    //}
    #endregion


    #region OncollisionEnter2D
    //private void OnCollisionEnter2D(Collision2D other) // temas ilk etdiginde
    //{
    //    Debug.Log(other.transform.name);
    //}

    //private void OnCollisionExit2D(Collision2D other) // temasdan cixtiginda 
    //{
    //    Debug.Log(other.transform.name);
    //}

    //private void OnCollisionStay2D(Collision2D other)  //temasa devam
    //{
    //    Debug.Log(other.transform.name);
    //}
    #endregion
}
