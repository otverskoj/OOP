

namespace lesson_6
{
    class Program
    {
        static void AddNewAccount()
        {
            System.Console.WriteLine("Adding new account...");
        }
        
        static void ConnectUSB()
        {
            System.Console.WriteLine("Connect USB...");
        }
        
        static void InstallNewGame()
        {
            System.Console.WriteLine("Install new game...");
        }
        
        static void ChangeGamepad()
        {
            System.Console.WriteLine("Change gamepad...");
        }
        
        static void Main(string[] args)
        {
            var consoles = Console.Generate100();

            var console = Console.Generate();

            #region console events

            // console.AddingNewAccount += AddNewAccount;
            // // console.AddingNewAccount += ConnectUSB;
            // // console.AddingNewAccount += InstallNewGame;
            // // console.AddingNewAccount += ChangeGamepad;
            // console.InvokeEventAddingNewAccount();
            //
            // // console.СonnectionUSB += AddNewAccount;
            // console.СonnectionUSB += ConnectUSB;
            // // console.СonnectionUSB += InstallNewGame;
            // // console.СonnectionUSB += ChangeGamepad;
            // console.InvokeEventСonnectionUSB();
            //
            // // console.InstallationNewGame += AddNewAccount;
            // // console.InstallationNewGame += ConnectUSB;
            // console.InstallationNewGame += InstallNewGame;
            // // console.InstallationNewGame += ChangeGamepad;
            // console.InvokeEventInstallationNewGame();
            //
            // // console.ChangingGamepad += AddNewAccount;
            // // console.ChangingGamepad += ConnectUSB;
            // // console.ChangingGamepad += InstallNewGame;
            // console.ChangingGamepad += ChangeGamepad;
            // console.InvokeEventChangingGamepad();

            #endregion

            #region console clone

            // var cloneConsole = (Console)console.Clone();
            // console.PrintInfo();
            // cloneConsole.PrintInfo();

            #endregion
        }
    }
}