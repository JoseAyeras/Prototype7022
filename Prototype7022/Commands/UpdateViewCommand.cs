using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prototype7022.ViewModels;

namespace Prototype7022.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private BaseViewModel vMod;

        public UpdateViewCommand(BaseViewModel vwm)
        {
            vMod = vwm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("UpdateViewCommand.Execute(\"" + parameter + "\")");
            switch (parameter)
            {
                case "Back":
                    vMod.SelectedViewModel = vMod.SelectedViewModel.getLast();
                    break;
                case "Combat":
                    vMod.SelectedViewModel = new CombatViewModel(vMod);
                    break;
                case "Engage":
                    vMod.SelectedViewModel = new EngageViewModel(vMod);
                    break;
                case "Home":
                    vMod.SelectedViewModel = new HomeViewModel(vMod);
                    break;
                case "Inventory":
                    vMod.SelectedViewModel = new InventoryViewModel(vMod);
                    break;
                case "LoadGame":
                    vMod.SelectedViewModel = new LoadViewModel(vMod);
                    break;
                case "NewGame":
                    vMod.SelectedViewModel = new NGViewModel(vMod);
                    break;
                case "Options":
                    vMod.SelectedViewModel = new OptionsViewModel(vMod);
                    break;
                case "Overworld":
                    vMod.SelectedViewModel = new OverworldViewModel(vMod);
                    break;
                case "Party":
                    vMod.SelectedViewModel = new PartyViewModel(vMod);
                    break;
                case "Pause":
                    vMod.SelectedViewModel = new PauseViewModel(vMod);
                    break;
                case "Records":
                    vMod.SelectedViewModel = new RecordsViewModel(vMod);
                    break;
                case "Save":
                    vMod.SelectedViewModel = new SaveViewModel(vMod);
                    break;
                case "Shop":
                    vMod.SelectedViewModel = new ShopViewModel(vMod);
                    break;
                case "UseItem":
                    vMod.SelectedViewModel = new UseItemViewModel(vMod);
                    break;
                case "UseMove":
                    vMod.SelectedViewModel = new UseMoveViewModel(vMod);
                    break;
                default:
                    Console.WriteLine("WARNING: View Not Implemented!!!!");
                    break;
            }

        }
    }
}
