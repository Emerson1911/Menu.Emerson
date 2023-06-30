namespace Menu2._0.views;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

	private void Resta_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Costo.Text) && !string.IsNullOrEmpty(Cliente.Text))
		{
			var dato1 = Convert.ToDouble(Costo.Text);
			var dato2 = Convert.ToDouble(Cliente.Text);
			var result = dato2 - dato1;

			Devolucion.Text = Convert.ToString(result);
		}
		else
		{
			DisplayAlert("Error", "Escrina en todos los campos animal", "Adoptado");
		}
    }
}