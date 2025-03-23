using Avalonia.Controls;
using Avalonia.Interactivity;
using Calculator.ViewModels;

namespace Calculator.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void clear(object? sender, RoutedEventArgs e)
    {
        output.Text = string.Empty;
    }

    private void zero(object? sender, RoutedEventArgs e)
    {
        output.Text += "0";
    }

    private void one(object? sender, RoutedEventArgs e)
    {
        output.Text += "1";
    }

    private void two(object? sender, RoutedEventArgs e)
    {
        output.Text += "2";
    }

    private void three(object? sender, RoutedEventArgs e)
    {
        output.Text += "3";
    }

    private void four(object? sender, RoutedEventArgs e)
    {
        output.Text += "4";
    }

    private void five(object? sender, RoutedEventArgs e)
    {
        output.Text += "5";
    }

    private void six(object? sender, RoutedEventArgs e)
    {
        output.Text += "6";
    }

    private void seven(object? sender, RoutedEventArgs e)
    {
        output.Text += "7";
    }

    private void eight(object? sender, RoutedEventArgs e)
    {
        output.Text += "8";
    }

    private void nine(object? sender, RoutedEventArgs e)
    {
        output.Text += "9";
    }

}
