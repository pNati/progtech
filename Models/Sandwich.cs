namespace WpfBurgerApp.Models
{
    public class Sandwich
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public bool IsSpicy { get; set; }
        public string Size { get; set; }
    }

    public class VeggieSandwich : Sandwich { }
    public class ChickenSandwich : Sandwich { public ChickenSandwich() => Name = "Csirke"; }
    public class PorkSandwich : Sandwich { public PorkSandwich() => Name = "Diszn�"; }
    public class BeefSandwich : Sandwich { public BeefSandwich() => Name = "Marha"; }
    
}





//using BurgerApp.Models;

//public class Sandwich
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string ImagePath { get; set; }
//    public decimal BasePrice { get; set; }
//    public string Type { get; set; }
//}

//namespace BurgerApp.Models
//{
//    // Alap oszt�ly
//    public abstract class Sandwich
//    {
//        public string Name { get; set; }
//        public bool IsSpicy { get; set; }
//        public string Size { get; set; }
//    }

//    // Vega vagy H�sos
//    public class VeggieSandwich : Sandwich { }
//    public abstract class MeatSandwich : Sandwich { }

//    // H�sos t�pusok
//    public class ChickenSandwich : MeatSandwich { public ChickenSandwich() => Name = "Csirke"; }
//    public class PorkSandwich : MeatSandwich { public PorkSandwich() => Name = "Diszn�"; }
//    public class BeefSandwich : MeatSandwich { public BeefSandwich() => Name = "Marha"; }
//}

//namespace BurgerApp.ViewModels
//{
//    public enum MenuStep { Start, VegOrMeat, MeatType, Size, Spicy, Complete }

//    public class MenuViewModel : INotifyPropertyChanged
//    {
//        private MenuStep _currentStep = MenuStep.Start;
//        public MenuStep CurrentStep
//        {
//            get => _currentStep;
//            set { _currentStep = value; OnPropertyChanged(); UpdateOptions(); }
//        }

//        public ObservableCollection<string> Options { get; } = new();
//        public ICommand SelectOptionCommand { get; }

//        // Selections
//        public bool IsVegetarian { get; private set; }
//        public BurgerApp.Models.Sandwich SelectedSandwich { get; private set; }

//        public MenuViewModel()
//        {
//            SelectOptionCommand = new RelayCommand(param => OnOptionSelected(param as string));
//            UpdateOptions();
//        }

//        private void UpdateOptions()
//        {
//            Options.Clear();
//            switch (CurrentStep)
//            {
//                case MenuStep.Start:
//                    Options.Add("Kezdj�k");
//                    break;
//                case MenuStep.VegOrMeat:
//                    Options.Add("Vega");
//                    Options.Add("H�sos");
//                    break;
//                case MenuStep.MeatType:
//                    if (!IsVegetarian)
//                    {
//                        Options.Add("Csirke");
//                        Options.Add("Diszn�");
//                        Options.Add("Marha");
//                    }
//                    else
//                    {
//                        // ha vega, ide j�hetnek vega t�pusok
//                        Options.Add("Veg�n Special");
//                        Options.Add("Sal�ta Szendvics");
//                    }
//                    break;
//                case MenuStep.Size:
//                    Options.Add("Kicsi");
//                    Options.Add("K�zepes");
//                    Options.Add("Nagy");
//                    break;
//                case MenuStep.Spicy:
//                    Options.Add("Cs�p�s");
//                    Options.Add("Nem cs�p�s");
//                    break;
//                case MenuStep.Complete:
//                    Options.Add("Befejezett v�laszt�s");
//                    break;
//            }
//        }

//        private void OnOptionSelected(string choice)
//        {
//            switch (CurrentStep)
//            {
//                case MenuStep.Start:
//                    CurrentStep = MenuStep.VegOrMeat;
//                    break;
//                case MenuStep.VegOrMeat:
//                    IsVegetarian = (choice == "Vega");
//                    CurrentStep = MenuStep.MeatType;
//                    break;
//                case MenuStep.MeatType:
//                    if (IsVegetarian)
//                        SelectedSandwich = new VeggieSandwich { Name = choice };
//                    else
//                        SelectedSandwich = choice switch
//                        {
//                            "Csirke" => new ChickenSandwich(),
//                            "Diszn�" => new PorkSandwich(),
//                            "Marha" => new BeefSandwich(),
//                            _ => null
//                        };
//                    CurrentStep = MenuStep.Size;
//                    break;
//                case MenuStep.Size:
//                    SelectedSandwich.Size = choice;
//                    CurrentStep = MenuStep.Spicy;
//                    break;
//                case MenuStep.Spicy:
//                    SelectedSandwich.IsSpicy = (choice == "Cs�p�s");
//                    CurrentStep = MenuStep.Complete;
//                    break;
//                case MenuStep.Complete:
//                    // v�gs� l�p�s
//                    break;
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;
//        private void OnPropertyChanged([CallerMemberName] string name = null) =>
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }
//}