using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiseaseEmitterManager : MonoBehaviour
{
    float previousCall = 0;
    float internalCooldown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        float timeOfCall = Time.time;
        
        if (timeOfCall > previousCall + internalCooldown)
        {
            UIController ui = FindObjectOfType<Canvas>().GetComponent<UIController>();
            ui.setDiseasePercent(ui.getDiseasePercent() + 0.1f);
            previousCall = timeOfCall;
        }
    }
}
