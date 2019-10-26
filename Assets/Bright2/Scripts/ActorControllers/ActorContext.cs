﻿using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers
{
    /// <summary>
    /// <see cref="Actor"/>を構成するのに必要なデータを持つクラス
    /// </summary>
    [CreateAssetMenu(menuName = "Bright2/ActorContext")]
    public sealed class ActorContext : ScriptableObject
    {
        [SerializeField]
        private AnimationSequenceElements animationSequences = default;
        public AnimationSequenceElements AnimationSequences => this.animationSequences;

        [SerializeField]
        private float jumpPower = default;
        public float JumpPower => this.jumpPower;

        [Serializable]
        public class AnimationSequenceElements
        {
            [SerializeField]
            private ActorAnimationSequence idle = default;
            public ActorAnimationSequence Idle => this.idle;

            [SerializeField]
            private ActorAnimationSequence run = default;
            public ActorAnimationSequence Run => this.run;

            [SerializeField]
            private ActorAnimationSequence jump = default;
            public ActorAnimationSequence Jump => this.jump;
        }
    }
}
