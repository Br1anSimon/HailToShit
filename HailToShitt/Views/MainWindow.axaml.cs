using System;
using System.Threading;
using System;
using Avalonia.Controls;

namespace HailToShit.Views;

public partial class MainWindow : Window
{
    Thread gameThread;
    public MainWindow()
    {
        gameThread = new Thread(new ThreadStart(GameLoop));
        InitializeComponent();
        
        gameThread.Start();
        
    }
    
    public void GameLoop()
    {
        while (gameThread != null)
        {
            Console.WriteLine("Game Looop Running");
            Thread.Sleep(100);
            //TODO: Update information such as character position
            //TODO: Draw the screen with the updated information
        }
            
    }
}