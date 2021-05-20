using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollisionHandler : MonoBehaviour {

    bool hasCollidedWithPlayer;

    void Start() {
        hasCollidedWithPlayer = false;
    }

    private void OnCollisionEnter(Collision other) {
        if (OtherCollisionObjectIsPlayer(other)) {
            if (!hasCollidedWithPlayer) {
                PlayerHitScore playerHitScore = GetPlayerHitScoreFromOtherCollisionObject(other);
                playerHitScore.IncrementHitScore();
                playerHitScore.LogPlayerHitScore();

                SetHasCollidedWithPlayer(true);
                SetObstacleMaterialColorRed();
            }
        }
    }

    private static bool OtherCollisionObjectIsPlayer(Collision otherCollisionObject) {
        return otherCollisionObject.gameObject.tag == "Player";
    }

    private static PlayerHitScore GetPlayerHitScoreFromOtherCollisionObject(Collision otherCollisionObject) {
        GameObject otherGameObject = otherCollisionObject.gameObject;
        return (PlayerHitScore) otherGameObject.GetComponent<PlayerHitScore>();
    }

    private void SetHasCollidedWithPlayer(bool hasCollidedWithPlayer) {
        this.hasCollidedWithPlayer = hasCollidedWithPlayer;
    }

    private void SetObstacleMaterialColorRed() {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
