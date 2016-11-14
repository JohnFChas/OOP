using System;

namespace EventsMadeSimple
{
    public delegate void PrintMessage();

    public class Runtime
    {
        #region TicTacToe example
        private event EventHandler GameDraw;
        private event EventHandler GameWon;
        #endregion

        // Declare an event by using the 'event'-keyword followed by the
        // event handler delegate type. The name of an event should describe
        // the condition for raising the event.
        private event PrintMessage ApplicationStarted;

        public void Start()
        {
            #region TicTacToe event example
            //GameDraw += (sender, e) =>
            //{
            //    DrawMessage();
            //};

            //GameWon += (sender, e) =>
            //{
            //    WinMessage();
            //};

            //// Check for win or draw
            //bool isDraw = false;
            //bool isWin = true;

            //if (isWin)
            //{
            //    OnGameWin(this, EventArgs.Empty);
            //}
            //else if (isDraw)
            //{
            //    OnGameDraw(this, EventArgs.Empty);
            //}
            #endregion

            ApplicationStarted += new PrintMessage(Message1);
            ApplicationStarted += new PrintMessage(Message2);

            //OnApplicationStarted();
            ApplicationStarted?.Invoke();
        }

        #region TicTacToe example
        private void DrawMessage()
        {
            Console.WriteLine("Game draw");
        }

        private void WinMessage()
        {
            Console.WriteLine("Game won");
        }

        public void OnGameDraw(object sender, EventArgs e)
        {
            GameDraw.Invoke(sender, e);
        }

        public void OnGameWin(object sender, EventArgs e)
        {
            GameWon?.Invoke(sender, e);
        }
        #endregion

        private void OnApplicationStarted()
        {
            ApplicationStarted.Invoke();
        }

        public void Message1()
        {
            Console.WriteLine("Welcome to this super cool application");
        }

        public void Message2()
        {
            Console.WriteLine("Everything is fine, all systems nominal");
        }
    }
}