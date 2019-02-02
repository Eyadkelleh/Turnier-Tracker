using System;
using System.Windows.Forms;
using TrackerLibary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        private bool _output;
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The create prize button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateFrom())
            {
               PrizeModel model = new PrizeModel();
                model.PlaceName = placeNameValue.Text;
                model.PlaceNumber = placeNumberValue.Text;
            }
        }

        private bool ValidateFrom()
        {
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNameValue.Text, out placeNumber);
            if (placeNumberValidNumber == false)
            {
                _output = false;
            }

            if (placeNumber < 1)
            {
                _output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                _output = false;
            }

            decimal prizeAmount = 0;
            bool prizeAmountDecimal = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            if (prizeAmountDecimal == false)
            {
                _output = false;
            }

            if (prizeAmount < 1)
            {
                _output = false;
            }

            int prizePerecentage = 0;
            bool prizePercentageInteger = int.TryParse(prizePercentageValue.Text, out prizePerecentage);
            if (prizePercentageInteger == false)
            {
                _output = false;
            }

            if (prizePerecentage < 0)
            {
                _output = false;
            }

            if (prizePerecentage > 100)
            {
                _output = false;
            }

            return _output;
        }
    }
}
