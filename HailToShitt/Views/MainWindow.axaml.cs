using System;
using System.Threading;
using Avalonia.Controls;

namespace HailToShit.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Thread thread = new Thread(new ThreadStart(GameLoop));
        thread.Start();
        
    }
    

    private void GameLoop()
    {
            
            Console.WriteLine("Hello");
            Thread.Sleep(100);
            
    }
}