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
            { "111", "222" },
        };



        bool encontrado = false;

        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuarios[i, 0] == txtUsuario.Text && usuarios[i, 1] == txtContrasena.Text)
            {
                string user;
                Navigation.PushAsync(new Views.Registro(user=txtUsuario.Text));
                encontrado = true;
                break;
            }
            else
            {
                DisplayAlert("Error", "Dato incorecto", "ok");
                break;
        }

        if (!encontrado)
        {
            DisplayAlert("Error", "Dato incorrecto", "ok");
        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Error", "Este programa fue desarrollado por:\nJair Centeno\nde 8vo Ingenieria en sistemas ", "ok");
    }
}