namespace acentenoExamen.Views;

public partial class Registro : ContentPage
{
	private string userConect="x";
    private double cuotaTotal;
    private double pagoTotal;
    public Registro(string user)
	{
		InitializeComponent();
		string lconect = user + " Conectado";

        lblConect.Text = lconect;
		userConect = lconect;


	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		double costoBase=300;
		double pagoIni = Convert.ToDouble(txtMontoInicial.Text);
		double descu = costoBase - pagoIni;
		double diferido = descu / 3;
		double interes = costoBase * 0.05;
		double cuotaToTal=diferido+interes;
		double pagoTotal = cuotaToTal * 3;


		lblCalculo.Text = cuotaToTal+"$";


    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {


		string fecha = dFechas.Date.ToString();
        
		Navigation.PushAsync(new Views.Resumen(cuotaTotal, pagoTotal,txtMontoInicial.Text, userConect, txtNombre.Text, txtApellido.Text, pkVolt.SelectedItem, pkCiudad.SelectedItem, fecha));
    }
}