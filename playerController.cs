using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializedField] _objectBehavior _objectBehavior;

    float _playerSpeed = 5f;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GameObject.GetComponent<Rigidbody2D>(); // Get player physics to manipute motion;
        _objectBehavior.SpawnObject(); // When the game starts, create random boxes to be caught
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal"); // Listen for a horizontal input i.e left or right arrow; a or d. returns -1, 0,1

        if(_inputHorizontal != 0) {
            // if player is not standing still;
            _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0f));  // AddForce causes motion to change smoothly but .velocity changes instantly
            
        }

    }
}
