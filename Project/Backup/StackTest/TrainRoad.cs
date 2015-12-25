using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;

namespace StackTest
{
    class TrainRoad
    {
        private IStack<int>[] _allRoad;
        private int _nextOut = 1;
        private int _UniqueMaxSize;
        private int _len;
        private int _minRoad = 0;
        private int _minTrain;

        // 初始化总共的轨道数,n个缓冲+1个最终,缓冲的最大容量
        public TrainRoad(int n, int max) 
        {
            _allRoad = new LinkStack<int>[n + 1];
            for (int i = 0; i < n + 1; i++) 
            {
                _allRoad[i] = new LinkStack<int>();
            }
            _len = n;
            _UniqueMaxSize = max;
        }
        // 重排函数
        public void Railroad(int[] p) 
        {
            int len = p.Length;
            _minTrain = len;
            for (int i = 0; i < len; i++) 
            {
                if (p[i] == _nextOut)
                {
                    Console.WriteLine("Move Car {0} from input to output", p[i]);
                    _nextOut++;
                    while (_minTrain == _nextOut)
                    {
                        this.OutRoad(2 * len);
                        _nextOut++;
                    }
                }
                else 
                {
                    this.IntoRoad(p[i]);
                }
            }
        }

        // 进入缓冲轨道
        public void IntoRoad(int train) 
        {
            int best = 0;
            for (int i = 0; i < _len; i++) 
            {
                if (!_allRoad[i].IsEmpty() && _allRoad[i].Length <= _UniqueMaxSize) 
                {
                    if (train < _allRoad[i].StackTop)
                    {
                        best = i;
                        Console.WriteLine("Move Car {0} from input to holding track {1}", train, i);
                        break;
                    }
                }
                else if (_allRoad[i].IsEmpty())
                {
                    best = i;
                    Console.WriteLine("Move Car {0} from input to holding track {1}", train, i);
                    break;
                }
                else 
                {
                    continue;
                }
            }
            _allRoad[best].Push(train);
            if (train < _minTrain) 
            {
                _minTrain = train;
                _minRoad = best;
            }
        }
        // 将车厢移动到最终轨道
        public void OutRoad(int len) 
        {
            int train = _allRoad[_minRoad].StackTop;
            Console.WriteLine("Move Car {0} from holding track {1} to output", _minTrain, _minRoad);
            _allRoad[_minRoad].Pop();
            _minTrain = len;
            _minRoad = 0;
            for (int i = 0; i < _len; i++) 
            {
                if (!_allRoad[i].IsEmpty()) 
                {
                    int min = _allRoad[i].StackTop;
                    if (min < _minTrain)
                    {
                        _minTrain = min;
                        _minRoad = i;
                    }
                }
            }
        }
    }
}
