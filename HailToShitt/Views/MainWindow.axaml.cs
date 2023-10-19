using System;
using System.Threading;
using System;
using System.Drawing;
using System.IO;
using System.Transactions;
using Avalonia.Controls;
using Avalonia.Svg.Skia;
using HailToShit.ViewModels;
using Image = Avalonia.Controls.Image;


namespace HailToShit.Views;

public partial class MainWindow : Window
{
    Thread gameThread;
    
    public MainWindow()
    {
        using var fileStream = File.OpenRead("C:/Users/pc/Documents/anotherimagetoview.jpg");
        ImageToLoad = new Bitmap(fileStream);
        InitializeComponent();
        gameThread = new Thread(new ThreadStart(GameLoop));
        gameThread.Start();
        

    }
    
    public void GameLoop()
    {
        while (gameThread != null)
        {
            Console.WriteLine("Game Looop Running");
            Thread.Sleep(100);
            //TODO: Update information such as character position
            update();
            //TODO: Draw the screen with the updated information
            
        }
            
    }

    public void update()
    {
    }

    public void paintComponent(Graphics g)
    {
        paintComponent(g);
    }

    
}