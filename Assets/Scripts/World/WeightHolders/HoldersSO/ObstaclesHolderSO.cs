﻿using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TEDinc.LinesRunner
{
    [CreateAssetMenu(menuName = nameof(LinesRunner) + "/" + nameof(ObstaclesHolderSO))]
    public sealed class ObstaclesHolderSO : BaseWeightHolder
    {
        [SerializeField]
        private ObstacleWeightHolder[] _obstacles;
        public ObstacleWeightHolder[] obstacles { get => _obstacles; private set => _obstacles = value; }
        public override WeightHolder[] collection { get => obstacles; protected set => obstacles = value as ObstacleWeightHolder[]; }

        public new GameObject GetNextByWeigth()
        {
            return base.GetNextByWeigth() as GameObject;
        }
    }

    [Serializable]
    public sealed class ObstacleWeightHolder : WeightHolder
    {
        [SerializeField]
        private GameObject _obstacle;
        public GameObject obstacle { get => _obstacle; private set => _obstacle = value; }
        public override Object obj { get => obstacle; protected set => obstacle = value as GameObject; }
        [SerializeField]
        public int _linesCount;
        public int linesCount { get => _linesCount; private set => _linesCount = value; }
    }
}