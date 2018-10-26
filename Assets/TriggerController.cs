using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TriggerController : MonoBehaviour
{
    public string TagName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagName))
        {
            GameManager.Instance.objectivesDone++;
            Debug.Log("Objective Done");
        }
    }
}
