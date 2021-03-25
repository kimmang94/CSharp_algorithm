using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();
            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25CF';
            //마지막 측정시간
            int lastTick = 0;

            while (true)
            {
                #region
                // 시작후 경과시간 ms단위
                int currentTick = System.Environment.TickCount;
  
                // 만약 경과시간이 1/30 초 보다 작다면
                if (currentTick - lastTick < WAIT_TICK) //1초는 1000ms
                    continue;
                lastTick = currentTick; // 30분에 1초마다 아래로 통과
                 // FPS 프레임 (60프레임 OK 30프레임 이하로 NO)
                #endregion

                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j <25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
