using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : item {
    [SerializeField] GameObject player;
    public override void ItemCatch()
    {
        int nowHeart = PlayerController.Instance.SetHeart;    //現在値取得
        Debug.Log(nowHeart);
        if(nowHeart < 4) {      //現在値が最大値より少ない
            PlayerController.Instance.SetHeart++;
        }
        
    }

}
