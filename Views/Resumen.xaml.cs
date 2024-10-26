using static System.Runtime.InteropServices.JavaScript.JSType;

namespace acentenoExamen.Views;
public partial class Resumen : ContentPage
{
	
	public Resumen(double cuotaTotal, double pagoTotal,string pagoIni, string userConect, string nombre, string apellido, object va, object ciudad, string fecha)
	{
		InitializeComponent();

		lblConect1.Text = userConect;
		lblnombre.Text = nombre;
		lblApellido.Text = apellido;
		lblVA.Text = Convert.ToString(va);
        lblFecha.Text = fecha;
		lblMontoIni.Text = Convert.ToString(pagoIni);
		lblCuotaMen.Text = Convert.ToString(cuotaTotal);
		lblPagoTot.Text = Convert.ToString(pagoTotal);
		lblCiudad.Text = Convert.ToString(ciudad);
		
		

		
	}

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Views.Login());
    }
}