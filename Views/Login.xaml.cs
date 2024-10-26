namespace acentenoExamen.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[,] usuarios =
        {
            { "estudiante2024", "cuisrael2024" },
            { "examen1", "parcial1" },
            { "NombreEstudiante", "2024" },
        };




        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuarios[i, 0] == txtUsuario.Text && usuarios[i, 1] == txtContrasena.Text)
            {
                string user=txtUsuario.Text;
                Navigation.PushAsync(new Views.Registro(user));
                break;
            }
            else
            {
                DisplayAlert("Error", "Dato incorecto", "ok");
                break;
            }
        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Error", "Este programa fue desarrollado por:\nJair Centeno\nde 8vo Ingenieria en sistemas ", "ok");
    }
}