using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.Initialize(25, player);
            player.Initialize(1, 1, board.Size - 2, board.Size - 2, board);

            const int WAIT_TICK = 1000 / 30;

            Console.CursorVisible = false;
            
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
                int deltaTick = currentTick - lastTick;
                lastTick = currentTick;
                #endregion

                //입력

                //로직
                player.Update(deltaTick);
                //렌더링
                Console.SetCursorPosition(0, 0);
                board.Render();

            }
        }
    }
}
