using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    // 연속될 필요가 없음
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next; // 참조(주소)값 저장
        public MyLinkedListNode<T> Prev;
    }

    class RoomList<T>
    {
        public MyLinkedListNode<T> Head = null; // 첫번째
        public MyLinkedListNode<T> Tail = null; // 마지막
        public int Count = 0;

        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            // 만약 아직 방이 아예 없다면 새로 추가한 첫번째 방이 곧 Head 이다.
            if (Head == null)
                Head = newRoom;

            // 101 102 103(tail) -> 104 추가한다면 
            // 기존에 [마지막 방]과 [새로 추가되는 방]을 연결해준다.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }
            // [새로 추가되는 방] 을 [마지막 방]으로 인정한다
            Tail = newRoom;
            Count++;
            return newRoom;
        }


        // 101 102 103 104 105 -> 연결해주고 사라진다 101 102 104 105
        public void Remove(MyLinkedListNode<T> room)
        {
            // [기존에 첫번째 방 다음방]을 [첫번째 방으로] 인정한다
            if (Head == room)
                Head = Head.Next;

            // [기존의 마지막 방의 이전방] 을 [마지막 방]으로 인정한다.
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }


    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyLinkedListNode<int> _data3 = new MyLinkedListNode<int>(); // 이중 연결 리스트

        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            LinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
