using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    [SerializeField] Button Stage1;
    [SerializeField] Button Stage2;

    void Start()
    {
        Stage1.onClick.AddListener(() =>
        {
            LoadManager.LoadScene("1Stage");
        });
    }
}
