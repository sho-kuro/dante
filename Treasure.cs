using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : item {
    [SerializeField] int addScore;

    public override void ItemCatch()
    {
        GameMaainManager.Instance.AddScore(addScore);
        Debug.Log(GameMaainManager.Instance.GetScore);
    }


}
