namespace Menu2._0.views;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    private void Dino_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Peso.Text)&& !string.IsNullOrEmpty(Altura.Text))
		{
			var dato1 = Convert.ToDouble(Peso.Text);
			var dato2 = Convert.ToDouble(Altura.Text);
			var multi = (dato1 * dato1) / dato2;
			Gordo.Text = Convert.ToString(multi);
			var libr = multi*2.2;
			Libras.Text = Convert.ToString(libr);
			var centi = (dato2 * 100) / 1;
			Centimetros.Text = Convert.ToString(centi);
		}
		else
		{
			DisplayAlert("Error", "Escribe el peso y la altura ciego", "Adoptado");
		}
    }
}