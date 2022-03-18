using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEmission : MonoBehaviour
{
    MeshRenderer meshRenderer;
    bool powerTime;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (powerTime)
        {
            meshRenderer.material.SetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b", meshRenderer.material.GetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b") + 0.03f);
            if (meshRenderer.material.GetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b") >= 5)
                powerTime = false;
        }
        else
        {
            meshRenderer.material.SetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b", meshRenderer.material.GetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b") - 0.03f);
            if (meshRenderer.material.GetFloat("Vector1_05df1427b04546e08e5547d8efc9a99b") <= 0)
                powerTime = true;
        }
    }
}
