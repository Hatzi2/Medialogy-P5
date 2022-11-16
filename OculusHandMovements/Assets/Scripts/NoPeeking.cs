using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPeeking : MonoBehaviour
{   
    [SerializeField] LayerMask collisionLayer;
    [SerializeField] float fadeSpeed;
    [SerializeField] float sphereCheckSize = .15f;

    private Material cameraFadeMat;
    private bool isCameraFaded = false;
    private void Awake() => cameraFadeMat = GetComponent<Renderer>().material;

    void update()
    {
        if (Physics.CheckSphere(transform.position, sphereCheckSize, collisionLayer, QueryTriggerInteraction.Ignore))
        {
            cameraFade(1f);
            isCameraFaded = true;
        }
        Debug.Log(isCameraFaded);
    }

    public void cameraFade(float targetAlpha)
    {
        var fadeValue = Mathf.MoveTowards(cameraFadeMat.color.a, targetAlpha, Time.deltaTime * fadeSpeed);

        if (fadeValue <= 0.01f)
        {
            isCameraFaded = false;
        }
    }
}
