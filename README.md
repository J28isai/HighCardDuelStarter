# High Card Duel (Starter)

## Run
1. Abrir `HighCardDuelStarter.sln` en Visual Studio 2022+
2. Restore NuGet packages (CommunityToolkit.Mvvm)
3. Ejecutar

## Lo que los estudiantes deben Implementar \ Verificar
- MVVM with CommunityToolkit:
  - `[ObservableProperty]` y `[RelayCommand]`
- Repository pattern:
  - `IGameSessionRepository` + `InMemoryGameSessionRepository`
- In-memory only (no files/DB)
- Buttons:
  - Draw Turn: genera 2 numeros random, actualiza el score, leader, history
  - Reset: Limpia Todo
