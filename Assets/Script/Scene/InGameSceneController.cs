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
        //���� ����� �߰�

        // 3 2 1 ����! text���
        StartCoroutine(StartCountDown());
        
    }
    private IEnumerator StartCountDown()
    {
        foreach( GameObject obj in countDown )
        {
            // ��! ȿ���� �߰�
            obj.SetActive(true);
            yield return new WaitForSeconds(1);
            obj.SetActive(false);
        }
    }

}
