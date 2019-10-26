﻿using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers.States
{
    /// <summary>
    /// アイドル状態を制御するクラス
    /// </summary>
    public sealed class Idle : ActorState
    {
        public Idle(Actor owner)
            :base(owner)
        {
        }

        public override void Enter()
        {
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}
