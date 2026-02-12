using HighCardDuelStarter.Repositories;
using HighCardDuelStarter.Services;
using HighCardDuelStarter.ViewModels;
using System.Windows;

namespace HighCardDuelStarter.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        RandomCardDealer cartas = new RandomCardDealer();
        DataContext = new MainViewModel(cartas);    
    }
}
