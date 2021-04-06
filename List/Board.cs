using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count; // 사용중인 데이터 갯수
        public int Capacity  { get {return _data.Length; } } // 예약된 데이터 갯수


        // O(1) 예외케이스 : 이사 비용은 무시 
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아있는지 확인
            if (Count >= Capacity)
            {
                // 공간을 다시 늘려서 확보한다.
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }
            // 2. 공간이 확보됫다면 공간에 데이터 삽입
            _data[Count] = item;
            Count++;
        }
        // O(1)
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }
        // 0(N)
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105 -> 101 102 104 105
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyList<int> _data2 = new MyList<int>(); // 동적 배열
        public LinkedList<int> _data3 = new LinkedList<int>(); // 이중 연결 리스트

        public void Initialize()
        {
            _data2.Add(101); // 추가
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data[2]; // 0부터 시작
            _data2.RemoveAt(2); // 삭제
        }
    }
}
