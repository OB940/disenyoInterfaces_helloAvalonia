using Avalonia.Controls;
using Avalonia.Media;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Title = "TÍTULO_CAMBIADO_EN_C#";
        this.saludo.Text = "TEXTO_CAMBIADO_EN_C#";
        this.saludo.Foreground = Brushes.Blue;

        Button boton2 = new Button()
        {
            Content = "BOTÓN2",
            Background = Brushes.LightGray,
            Width = 80,
            HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalContentAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        panel.Children.Add(boton2);

    }



    
}