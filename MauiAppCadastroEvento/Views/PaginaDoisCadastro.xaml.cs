using MauiAppCadastroEvento.Models;

namespace MauiAppCadastroEvento.Views;

public partial class PaginaDoisCadastro : ContentPage
{
    public PaginaDoisCadastro(Evento evento)
    {
        InitializeComponent();

        // Define o BindingContext para exibir os dados do evento
        BindingContext = evento;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}