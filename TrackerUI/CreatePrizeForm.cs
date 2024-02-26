using LibraryTracker;

namespace CreatePrizeForm
{
    public partial class createPrizeForm : Form
    {
        public createPrizeForm()
        {
            InitializeComponent();
        }

        private void CreateTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, placeNumberValue.Text, priceAmountValue.Text, pricePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }

            else
            {
                MessageBox.Show("Invalid form details. Please check!!!!!!!!");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool PlaceNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (PlaceNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }


            decimal PrizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(priceAmountValue.Text, out PrizeAmount);
            bool prizePercentageValid = double.TryParse(pricePercentageValue.Text, out prizePercentage);
            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (PrizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;

            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
