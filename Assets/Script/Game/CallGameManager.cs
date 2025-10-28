using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallGameManager : MonoBehaviour
{
    public void CallExitGame()
    {
        GameManager.ins.ExitGame();
    }
    public void CallStartGame()
    {
        GameManager.ins.StartGame();
    }
}
