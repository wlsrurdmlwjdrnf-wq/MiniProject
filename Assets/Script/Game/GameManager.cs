using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;

    [SerializeField] private bool gamePaused = false;

    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void StartGame() // ���ӽ��� ��ư
    {
        SceneManager.LoadScene("InGame");
    }
    public void ExitGame() // ���ӳ����� ��ư
    {
        Application.Quit();
    }

    public void PlayGame() // ���� ���¿��� ������ �� ���
    {
        gamePaused = false;
    }
    public void StopGame() // ���� �Ͻ� ����
    {
        gamePaused = true;
    }

    public void StartRound()
    {
        if (!gamePaused)
        {
            //������� ����
        }
    }

}
