using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';
            Console.CursorVisible = false;
            // 시간측정
            int lastTick = 0;
            while (true)
            {
                #region 프레임관리
                // FPS 프레임
                int currentTick = Environment.TickCount; //(시스템 시작후 경과시간 ms) 현재시간
                // 경과 시간 1초 = 1000ms
                // 만약 경과시간이 1/30초 보다 작다면 
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion
                // 입력
                // 사용자가 키보드 혹은 마우스 입력 input

                // 로직
                // 입력에 따라 로직 동작

                // 렌더링
                // 게임세상을 그려줌
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine(); // 개행
                }
            }
        }
    }
}
