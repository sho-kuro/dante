using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPickel : item {

    public override void ItemCatch()
    {
        GameMaainManager.Instance.NewPickel = true;
        Debug.Log(GameMaainManager.Instance.NewPickel);
    }
}
