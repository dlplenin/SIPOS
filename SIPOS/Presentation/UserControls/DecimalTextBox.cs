using System.Globalization;
using System.Windows.Forms;

namespace SIPOS.Presentation.UserControls
{
    public partial class DecimalTextBox : TextBox
	{
		public DecimalTextBox()
		{
			InitializeComponent();
		}

		public int DecimalPlaces { get; set; } = 2;

        public string TextOrDefault
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(Text))
                    return "0";
                return Text;
            }
        }

        public decimal DecimalValue
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Text))
                    return 0M;
                return Convert.ToDecimal(Text);
            }
        }

        protected override void OnTextChanged(EventArgs e)
		{
			if (IsValidDecimal())
				base.OnTextChanged(e);
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
        {
            var decimalSymbol = Convert.ToChar(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            string[] decimalSeparators = { ",", "." };
            if (decimalSeparators.Contains(e.KeyChar.ToString()))
            {
                e.KeyChar = decimalSymbol;
            }

            if (IsNotAllowedKey(e, decimalSymbol))
                e.Handled = true;

            if (MoreThanOneDecimalSymbol(e, decimalSymbol))
                e.Handled = true;

			if (Text.Split(decimalSymbol).Last().Length >= DecimalPlaces && (Keys)e.KeyChar != Keys.Back && this.SelectionLength <= 0)
				e.Handled = true;

            base.OnKeyPress(e);
        }

        private bool MoreThanOneDecimalSymbol(KeyPressEventArgs e, char decimalSymbol)
        {
            return e.KeyChar == decimalSymbol && Text.IndexOf(decimalSymbol) > 0;
        }

        private static bool IsNotAllowedKey(KeyPressEventArgs e, char decimalSymbol)
        {
            return !char.IsNumber(e.KeyChar)
                            && ((Keys)e.KeyChar != Keys.Back)
                            && (e.KeyChar != decimalSymbol);
        }

        protected override void OnGotFocus(EventArgs e)
		{
			ResetValueOnFocus();
			base.OnGotFocus(e);
		}

		private void ResetValueOnFocus()
		{
			var validValue = IsValidDecimal() && !IsDecimalZero();
			if (validValue)
				return;
			Text = string.Empty;
		}

		private bool IsValidDecimal()
		{
            return decimal.TryParse(Text, out _);
		}

		private bool IsDecimalZero()
		{
			return (decimal.Parse(Text) == 0);
		}
    }
}
