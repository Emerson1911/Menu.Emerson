namespace Menu2._0.views;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Altura.Text)&& !string.IsNullOrEmpty(Base.Text))
		{
			var dato1 = Convert.ToDouble(Altura.Text);
			var dato2 = Convert.ToDouble(Base.Text);
			var dato3 = (dato2 * dato1) / 2;
			Superfici.Text = Convert.ToString(dato3);
		}
		else
		{
			DisplayAlert("Error", "Introduzca la base y la altura", "Adoptado");
		}
    }
}