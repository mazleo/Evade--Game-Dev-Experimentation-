using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerFunctionality : MonoBehaviour {
    private const int SPIN_COUNTER_CLOCKWISE = 0;
    private const int SPIN_CLOCKWISE = 1;

    private int rotateDirection = SPIN_CLOCKWISE;

    void Start() {
        rotateDirection = GetRandomRotateDirection();
    }

    void Update() {
        float degreesToRotate = 0.3f;

        float yAngleRotationDegrees = SetYAngleWithDirection(degreesToRotate);
        float xAngleRotationDegrees = 0f;
        float zAngleRotationDegrees = 0f;

        RotateSpinner(xAngleRotationDegrees, yAngleRotationDegrees, zAngleRotationDegrees);
    }

    private int GetRandomRotateDirection() {
        float randomNumber = Random.Range(0, 100);
        bool isRandomNumberEven = randomNumber % 2 == 0;

        if (isRandomNumberEven) {
            return SPIN_CLOCKWISE;
        }
        else {
            return SPIN_COUNTER_CLOCKWISE;
        }
    }

    float SetYAngleWithDirection(float degreesToRotate) {
        return rotateDirection == SPIN_CLOCKWISE ? degreesToRotate : -1 * degreesToRotate;
    }

    void RotateSpinner(float xAngleRotationDegrees, float yAngleRotationDegrees, float zAngleRotationDegrees) {
        transform.Rotate(xAngleRotationDegrees, yAngleRotationDegrees, zAngleRotationDegrees);
    }
}
