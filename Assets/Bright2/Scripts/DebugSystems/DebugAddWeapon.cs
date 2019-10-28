﻿using System.Collections.Generic;
using HK.Bright2.Database;
using HK.Bright2.GameSystems.Messages;
using HK.Framework.EventSystems;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.DebugSystems
{
    /// <summary>
    /// デバッグで武器を追加するクラス
    /// </summary>
    public sealed class DebugAddWeapon : MonoBehaviour
    {
        [SerializeField]
        private List<WeaponRecord> equippedWeapons = default;

        [SerializeField]
        private List<WeaponRecord> possessionWeapons = default;

        void Awake()
        {
            Broker.Global.Receive<SpawnedActor>()
                .SubscribeWithState(this, (x, _this) =>
                {
                    for (var i = 0; i < _this.equippedWeapons.Count; i++)
                    {
                        x.Actor.StatusController.SetWeapon(i, _this.equippedWeapons[i]);
                    }
                    foreach(var w in _this.possessionWeapons)
                    {
                        x.Actor.StatusController.AddWeapon(w);
                    }
                })
                .AddTo(this);
        }
    }
}
