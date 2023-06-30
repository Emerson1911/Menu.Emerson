namespace Menu2._0.views;

public partial class Gasolina : ContentPage
{
	public Gasolina()
	{
		InitializeComponent();
	}

    private void Convercion_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Litros.Text)&& !string.IsNullOrEmpty(Costo.Text))
		{
			var dato1 = Convert.ToInt32(Litros.Text);
			var dato2 = Convert.ToDouble(Costo.Text);
			var datos = (1 * dato1) / 3.78;
			Galones.Text = Convert.ToString(datos);
			var datos1 = datos * dato2;
			Cobrar.Text = Convert.ToString(datos1);
		}
		else
		{
			DisplayAlert("Error", "Introduzca los litros", "Adoptado");
		}
    }
}