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
    public class PorkSandwich : Sandwich { public PorkSandwich() => Name = "Disznó"; }
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
//    // Alap osztály
//    public abstract class Sandwich
//    {
//        public string Name { get; set; }
//        public bool IsSpicy { get; set; }
//        public string Size { get; set; }
//    }

//    // Vega vagy Húsos
//    public class VeggieSandwich : Sandwich { }
//    public abstract class MeatSandwich : Sandwich { }

//    // Húsos típusok
//    public class ChickenSandwich : MeatSandwich { public ChickenSandwich() => Name = "Csirke"; }
//    public class PorkSandwich : MeatSandwich { public PorkSandwich() => Name = "Disznó"; }
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
//                    Options.Add("Kezdjük");
//                    break;
//                case MenuStep.VegOrMeat:
//                    Options.Add("Vega");
//                    Options.Add("Húsos");
//                    break;
//                case MenuStep.MeatType:
//                    if (!IsVegetarian)
//                    {
//                        Options.Add("Csirke");
//                        Options.Add("Disznó");
//                        Options.Add("Marha");
//                    }
//                    else
//                    {
//                        // ha vega, ide jöhetnek vega típusok
//                        Options.Add("Vegán Special");
//                        Options.Add("Saláta Szendvics");
//                    }
//                    break;
//                case MenuStep.Size:
//                    Options.Add("Kicsi");
//                    Options.Add("Közepes");
//                    Options.Add("Nagy");
//                    break;
//                case MenuStep.Spicy:
//                    Options.Add("Csípõs");
//                    Options.Add("Nem csípõs");
//                    break;
//                case MenuStep.Complete:
//                    Options.Add("Befejezett választás");
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
//                            "Disznó" => new PorkSandwich(),
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
//                    SelectedSandwich.IsSpicy = (choice == "Csípõs");
//                    CurrentStep = MenuStep.Complete;
//                    break;
//                case MenuStep.Complete:
//                    // végsõ lépés
//                    break;
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;
//        private void OnPropertyChanged([CallerMemberName] string name = null) =>
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }
//}