using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingMechanism : MonoBehaviour {

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    float timeToDropInSeconds;

    bool hasBeenExposedAndDropped;

    // Start is called before the first frame update
    void Start() {
        CacheMeshRenderer();
        CacheRigidbody();

        InitializeDroppingObject();
        InitializeFields();
    }

    // Update is called once per frame
    void Update() {
        if (!hasBeenExposedAndDropped && HasCurrentTimePassedTimeToDrop()) {
            ExposeAndDropDroppingObject();
        }
    }

    private void CacheMeshRenderer() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void CacheRigidbody() {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void InitializeDroppingObject() {
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    private void InitializeFields() {
        timeToDropInSeconds = GetRandomTimeInSeconds();
        hasBeenExposedAndDropped = false;
    }

    private float GetRandomTimeInSeconds() {
        float minTime = 0f;
        float maxTime = 60f;
        
        return Random.Range(minTime, maxTime);
    }

    private bool HasCurrentTimePassedTimeToDrop() {
        return Time.time >= timeToDropInSeconds;
    }

    private void ExposeAndDropDroppingObject() {
        meshRenderer.enabled = true;
        rigidbody.useGravity = true;
        hasBeenExposedAndDropped = true;
    }
}
