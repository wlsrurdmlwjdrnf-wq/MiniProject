using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSceneController : MonoBehaviour
{
    //awake -> onenable -> sceneloaded -> start
    public GameObject[] countDown;
   
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //게임 배경음 추가

        // 3 2 1 시작! text출력
        StartCoroutine(StartCountDown());
        
    }
    private IEnumerator StartCountDown()
    {
        foreach( GameObject obj in countDown )
        {
            // 띵! 효과음 추가
            obj.SetActive(true);
            yield return new WaitForSeconds(1);
            obj.SetActive(false);
        }
    }

}
