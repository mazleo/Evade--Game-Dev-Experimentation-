using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitScore : MonoBehaviour {

    private int hitScore;

    void Start() {
        hitScore = 0;
    }

    public void IncrementHitScore() {
        hitScore++;
    }

    public void LogPlayerHitScore() {
        Debug.Log("Hit Score: " + hitScore);
    }

}
