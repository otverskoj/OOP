using System;
using System.Collections.Generic;

namespace lesson_6
{
    public delegate void EventDelegate();
    
    public class Console : IConsole, IHack, ICloneable
    {

        #region events

        #region AddingNewAccount

        private event EventDelegate addingNewAccount;
        
        public event EventDelegate AddingNewAccount
        {
            add
            {
                if (value.Method.Name.Contains("Account"))
                {
                    addingNewAccount += value;
                }
            }
            remove { addingNewAccount -= value; }
        }
        
        public void InvokeEventAddingNewAccount()
        {
            addingNewAccount.Invoke();
        }

        #endregion

        #region ConnectionUSB

        private event EventDelegate connectionUSB;
        
        public event EventDelegate СonnectionUSB
        {
            add
            {
                if (value.Method.Name.Contains("USB"))
                {
                    connectionUSB += value;
                }
            }
            remove { connectionUSB -= value; }
        }
        
        public void InvokeEventСonnectionUSB()
        {
            connectionUSB.Invoke();
        }

        #endregion

        #region InstallationNewGame
        
        private event EventDelegate installationNewGame;
        
        public event EventDelegate InstallationNewGame
        {
            add
            {
                if (value.Method.Name.Contains("NewGame"))
                {
                    installationNewGame += value;
                }
            }
            remove { installationNewGame -= value; }
        }
        
        public void InvokeEventInstallationNewGame()
        {
            installationNewGame.Invoke();
        }

        #endregion

        #region ChangingGamepad

        private event EventDelegate changingGamepad;
        
        public event EventDelegate ChangingGamepad
        {
            add
            {
                if (value.Method.Name.Contains("Gamepad"))
                {
                    changingGamepad += value;
                }
            }
            remove { changingGamepad -= value; }
        }
        
        public void InvokeEventChangingGamepad()
        {
            changingGamepad.Invoke();
        }

        #endregion

        #endregion

        #region static fields

        private static List<string>[] _consoleNames =
        {
            new List<string>() {"PlayStation2", "PlayStation3", "PlayStation4"},
            new List<string>() {"Xbox1", "Xbox2", "Xbox3"},
            new List<string>() {"Switch", "3ds"},
            new List<string>() {"Dreamcast", "Mega Drive / Genesis", "Game Gear"}
        };

        private static List<string> _games = new List<string>
        {
            "CS:GO", "Dota 2", "Fortnite", "PUBG", "Realm Royale", "Rocket League", "Don't Starve"
        };

        private static List<string> _accounts = new List<string>()
        {
            "Vuvu Man", "Jakare", "Digo", "Lunar", "Laker228"
        };

        #endregion

        #region public properties

        public ProcessorTypes ProcessorType { get; set; }
        public ManufacturerNames ManufactName { get; set; }
        public MediaTypes MediaType { get; set; }
        public string ConsoleName { get; set; }
        public int HardDiskCapacity { get; set; }
        public List<string> InstalledGames { get; set; }
        public List<string> SystemAccounts { get; set; }

        #endregion

        #region public methods
        
        public object Clone()
        {
            return new Console()
            {
                ProcessorType = this.ProcessorType,
                ManufactName = this.ManufactName,
                MediaType = this.MediaType,
                ConsoleName = this.ConsoleName,
                HardDiskCapacity = this.HardDiskCapacity,
                InstalledGames = this.InstalledGames,
                SystemAccounts = this.SystemAccounts
            };
        }

        public bool TrySoftwareHack()
        {
            return false;
        }

        public bool TryHardwareHack()
        {
            return false;
        }
        
        public void PrintInfo()
        {
            System.Console.Write($"Консоль {this.ConsoleName} " +
                                 $"производителя {this.ManufactName} " +
                                 $"типа {this.MediaType} ");

            System.Console.Write("с аккаунтами ");
            this.SystemAccounts.ForEach(acc => System.Console.Write($"{acc}, "));
            System.Console.Write("и играми ");
            this.InstalledGames.ForEach(g => System.Console.Write($"{g}, "));

            System.Console.Write($"имеет процессор {this.ProcessorType}, " +
                                 $"жёсткий диск объёмом {this.HardDiskCapacity} Гб.\n");
        }

        #endregion

        #region constructors

        private Console()
        {
            this.ProcessorType = ProcessorTypes.Intel;
            this.ManufactName = ManufacturerNames.Microsoft;
            this.MediaType = MediaTypes.CD;
            this.ConsoleName = "Xbox";
            this.HardDiskCapacity = 16;
            this.InstalledGames = new List<string>();
            this.SystemAccounts = new List<string>();
        }

        private Console(ProcessorTypes processorType, ManufacturerNames manufacturerNames, MediaTypes mediaType,
            string consoleName, int hardDiskCapacity, List<string> installedGames, List<string> systemAccounts)
        {
            this.ProcessorType = processorType;
            this.ManufactName = manufacturerNames;
            this.MediaType = mediaType;
            this.ConsoleName = consoleName;
            this.HardDiskCapacity = hardDiskCapacity;
            this.InstalledGames = installedGames;
            this.SystemAccounts = systemAccounts;
        }

        #endregion

        #region static methods

        private static List<string> GetGamesList()
        {
            var games = new List<string>();

            var numbers = new List<int>();
            for (int i = 0; i < _games.Count; i++)
            {
                numbers.Add(i);
            }
            
            var rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                var deleteIndex = rnd.Next(numbers.Count);
                var index = numbers[deleteIndex];
                games.Add(_games[index]);
                numbers.RemoveAt(deleteIndex);
            }

            return games;
        }

        private static List<string> GetAccountsList()
        {
            var accounts = new List<string>();

            var numbers = new List<int>();
            for (int i = 0; i < _accounts.Count; i++)
            {
                numbers.Add(i);
            }
            
            var rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                var deleteIndex = rnd.Next(numbers.Count);
                var index = numbers[deleteIndex];
                accounts.Add(_accounts[index]);
                numbers.RemoveAt(deleteIndex);
            }

            return accounts;
        }
        
        public static Console Generate()
        {
            var rnd = new Random();
            var manufactIndex = rnd.Next(4);
            var nameIndex = rnd.Next(_consoleNames[manufactIndex].Count);
            return new Console((ProcessorTypes) rnd.Next(1, 3), (ManufacturerNames) manufactIndex+1,
                (MediaTypes) rnd.Next(1, 4), _consoleNames[manufactIndex][nameIndex],
                rnd.Next(101), GetGamesList(), GetAccountsList());
        }

        public static List<Console> Generate100()
        {
            const int generationNumber = 10;
            var consoles = new List<Console>();
            
            for (var i = 0; i < generationNumber; i++)
            {
                consoles.Add(Generate());
            }

            return consoles;
        }

        #endregion
        
    }
}