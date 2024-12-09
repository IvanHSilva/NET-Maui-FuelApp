namespace FuelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            try {

                double etanol = Convert.ToDouble(txtAlc.Text);
                double gas = Convert.ToDouble(txtGas.Text);

                string msg;

                if (etanol <= (gas * 0.7)) {
                    msg = "Etanol está compensando mais!";
                } else {
                    msg = "Gasolina está compensando mais!";
                }
                DisplayAlert("Resultado", msg, "Ok");


            } catch (Exception ex) {
                DisplayAlert("Erro no app!", ex.Message, "Ok");
            }
        }
    }
}
