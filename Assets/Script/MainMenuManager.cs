using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button btnStart;
    [SerializeField] Button btnQuit;
    [SerializeField] Button CheckQuit;
    [SerializeField] Button CheckReturn;
    [SerializeField] GameObject CheckPanel;

    private void Awake()
    {
        CheckPanel.SetActive(false);
    }
    void Start()
    {

        btnStart.onClick.AddListener(() =>
        {
            LoadManager.LoadScene("SelectStage");
        });

        btnQuit.onClick.AddListener(() =>
        {
            CheckPanel.SetActive(true);
        });

        CheckQuit.onClick.AddListener(() =>
        {
#if UNITY_EDITOR

            UnityEditor.EditorApplication.isPlaying = false;
#else
           Application.Quit();
#endif
        });

        CheckReturn.onClick.AddListener(() =>
        {
            CheckPanel.SetActive(false);
        });
    }

    void Update()
    {
        //����Ȯ���г��� ���� ���¿��� escŰ�� ������ â�� ����
        if(Input.GetKeyDown(KeyCode.Escape) && CheckPanel == true)
        {
            CheckPanel.SetActive(false);
        }
    }
}
