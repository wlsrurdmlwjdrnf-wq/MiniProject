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
    public void StartGame() // 게임시작 버튼
    {
        SceneManager.LoadScene("InGame");
    }
    public void ExitGame() // 게임나가기 버튼
    {
        Application.Quit();
    }

    public void PlayGame() // 정지 상태에서 시작할 때 사용
    {
        gamePaused = false;
    }
    public void StopGame() // 게임 일시 정지
    {
        gamePaused = true;
    }

    public void StartRound()
    {
        if (!gamePaused)
        {
            //라운드시작 로직
        }
    }

}
