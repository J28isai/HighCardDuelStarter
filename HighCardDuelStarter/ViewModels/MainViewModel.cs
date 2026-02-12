using System.Collections.ObjectModel;
using System.DirectoryServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HighCardDuelStarter.Models;
using HighCardDuelStarter.Repositories;
using HighCardDuelStarter.Services;

namespace HighCardDuelStarter.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    public string player1Name = "Player 1";

    [ObservableProperty]
    public string player2Name = "Player 2";

    [ObservableProperty]
    public string player1Card = "-";

    [ObservableProperty]
    public string player2Card = "-";

    public MainViewModel(ICardDealer cartas)
    {
        Cartas = cartas;
    }

    public ICardDealer Cartas { get; }
}


