using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(LensFlareComponentSRP))]
public class lensFlareEffects : MonoBehaviour
{
    public bool useOcclusion = false;

    [Header("Occlusion Settings")]
    [Range(0f, 5f)] public float occlusionSpeed = 1f; // Speed of intensity change when occluded or revealed
    public float occlusionDistance = 1000f;
    public LayerMask occlusionLayerMask;

    private float occludedIntensity = 0f; // Intensity when occluded
    private float targetIntensity; // Target intensity that we want to reach
    private float originalIntensity; // To restore the original intensity

    private LensFlareComponentSRP lensFlare;

    private void Start()
    {
        lensFlare = GetComponent<LensFlareComponentSRP>();
        originalIntensity = lensFlare.intensity;
        targetIntensity = originalIntensity;
    }

    private void Update()
    {
        if (useOcclusion)
        {
            Vector3 origin = Camera.main.transform.position;
            Vector3 direction = transform.forward;
            Vector3 targetPosition = origin - direction * occlusionDistance;

            RaycastHit hit;
            bool isOccluded = Physics.Linecast(origin, targetPosition, out hit, occlusionLayerMask);

            targetIntensity = isOccluded ? occludedIntensity : originalIntensity;
        }
        else
        {
            targetIntensity = originalIntensity;
        }

        // Lerp the intensity
        lensFlare.intensity = Mathf.Lerp(lensFlare.intensity, targetIntensity, Time.deltaTime * occlusionSpeed);
    }
}
