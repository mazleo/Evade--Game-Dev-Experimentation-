using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    void Update() {
        float moveSpeed = 25f;

        MovePlayerDependingOnInput(moveSpeed);
    }

    private void MovePlayerDependingOnInput(float moveSpeed) {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        float xTranslate = horizontalAxis * Time.deltaTime * moveSpeed;
        float yTranslate = 0;
        float zTranslate = verticalAxis * Time.deltaTime * moveSpeed;

        transform.Translate(xTranslate, yTranslate, zTranslate);
    }

}
