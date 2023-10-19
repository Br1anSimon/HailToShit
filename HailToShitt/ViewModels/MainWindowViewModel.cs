
using System;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace HailToShit.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
	
	public Bitmap ImageToView { get; set; }
	private Bitmap? ImageToLoad;
	public Bitmap? ImageToLoadPublic
	{
		get => ImageToLoad;
		private set => this.RaiseAndSetIfChanged(ref ImageToLoad, value);
	}
	
}