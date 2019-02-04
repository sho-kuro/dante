using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHelmet : item {
    public override void ItemCatch()
    {
        GameMaainManager.Instance.NewHelmet = true;

    }
}
