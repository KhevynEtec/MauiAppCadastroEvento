using MauiAppCadastroEvento.Models;
namespace MauiAppCadastroEvento.Views;

public partial class PaginainicialCadastro : ContentPage
{
	public PaginainicialCadastro()
	{
		InitializeComponent();

        dtpck_datainicio.MinimumDate = DateTime.Now;
        dtpck_datainicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_datatermino.MinimumDate = dtpck_datainicio.Date.AddDays(1);
        dtpck_datatermino.MaximumDate = dtpck_datainicio.Date.AddMonths(1);
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Cria um objeto Evento com os dados preenchidos
            var evento = new Evento
            {
                Descricao = txt_NomeEvento.Text,
                DataInicio = dtpck_datainicio.Date,
                DataTermino = dtpck_datatermino.Date,
                NumeroParticipantes = (int)stp_participantes.Value,
                Local = txt_LocalEvento.Text,
                CustoPorParticipante = decimal.TryParse(CustoEntry.Text, out var custo) ? custo : 0
            };

            // Navega para a página de resumo com os dados do evento
            Navigation.PushAsync(new PaginaDoisCadastro(evento));
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private void dtpck_datainicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_datatermino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_datatermino.MaximumDate = data_selecionada_inicio.AddMonths(1);
    }
}