using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectBehavior : MonoBehaviour
{

    [SerializedField] GameObject prefab;
    bool _gameOver = false

    public void SpawnObject() {
        Instatiate(prefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity); // Create game objects at random x-axis, 6f high
    }

    // listen for collisions
    private void OnCollisionEnter2D(Collision2D collision) {
        // if an object collides with a player and it is not not game over;

        if (collision.GameObject.tag == "Player" && !_gameOver) {
            SpawnObject(); // create a new box
            Destroy(GameObject);
        } else if (collision.GameObject.tag == "Ground") {
            _gameOver = true;
            Debug.Log("Game Over");
        }
    }
}
