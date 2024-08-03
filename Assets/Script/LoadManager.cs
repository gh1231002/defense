using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    [SerializeField] Image LoadBar;
    static string nextScene;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadSceneAsync("Loading");
    }

    private void Start()
    {
        StartCoroutine(basicLoadSceneProcess());
    }

    IEnumerator basicLoadSceneProcess()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;

        float timer = 0f;

        while (!op.isDone)
        {
            yield return null;
            if (op.progress < 0.9f)
            {
                LoadBar.fillAmount = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                LoadBar.fillAmount = Mathf.Lerp(0f, 1f, timer);
                if (LoadBar.fillAmount >= 1f)
                {
                    yield return new WaitForSeconds(1f);

                    op.allowSceneActivation = true;
                    break;
                }
            }
        }
    }
}
