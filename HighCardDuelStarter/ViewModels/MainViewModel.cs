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

    //Hubiera usado las propiedades declaradas para usarlas en relay commands que le asignaran a las variables playercard su carta correspondiente
    //proveniente del randomcard dealer usando la lista suits y la lista ranks.
    // para usar esas listas inyectar lo que contiene la clase RandomCardealer en una propiedad con nombre por ejemplo repo
    // en el ui usar bindings hacia las variables del nombre, y los command que inicien el juego
    public MainViewModel(ICardDealer cartas)
    {
        Cartas = cartas;
    }

    public ICardDealer Cartas { get; }
}


