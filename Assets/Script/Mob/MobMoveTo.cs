using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobMoveTo : MonoBehaviour
{
    private int wayPointCount;
    private Transform[] waypoint;
    private int curIndex = 0;
    private MobMove mobMove;

    public void SetWayPoint(Transform[] wayPoint)
    {
        mobMove = GetComponent<MobMove>();

        wayPointCount = wayPoint.Length;
        waypoint = new Transform[wayPointCount];
        waypoint = wayPoint;

        transform.position = wayPoint[curIndex].position;

        StartCoroutine("MoveOn");
    }

    private IEnumerator MoveOn()
    {
        NextMove();

        while (true)
        {
            if (Vector3.Distance(transform.position, waypoint[curIndex].position) < 0.02f * mobMove.MoveSpeed)
            {
                NextMove();
            }

            yield return null;
        }
    }

    private void NextMove()
    {
        if (curIndex < wayPointCount - 1)
        {
            transform.position = waypoint[curIndex].position;

            curIndex++;
            Vector3 dir = (waypoint[curIndex].position - transform.position).normalized;
            mobMove.MoveMob(dir);
        }
        else
        {
            curIndex = 1;
            Vector3 dir = (waypoint[curIndex].position - transform.position).normalized;
            mobMove.MoveMob(dir);
        }
    }
}
