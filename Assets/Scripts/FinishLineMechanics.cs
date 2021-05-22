using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineMechanics : MonoBehaviour {

    private void OnCollisionEnter(Collision other) {
        GameObject playerGameObject = null;

        if (IsOtherThePlayer(other)) {
            playerGameObject = other.gameObject;

            SetMaterialColorGreen();

            PlayerHitScore playerHitScore = (PlayerHitScore) playerGameObject.GetComponent<PlayerHitScore>();
            LogToIndicateGameFinished(playerHitScore);
        }
    }

    private bool IsOtherThePlayer(Collision other) {
        return other.gameObject.tag == "Player";
    }

    private void SetMaterialColorGreen() {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void LogToIndicateGameFinished(PlayerHitScore playerHitScore) {
        Debug.Log("You reached the finish line!");
        playerHitScore.LogPlayerHitScore();
    }

}
