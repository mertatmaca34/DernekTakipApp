namespace DernekTakipApp.Utils
{
    public static class ColorTransformations
    {
        public static void Replace(TableLayoutPanel tableLayoutPanel, Button button)
        {
            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is Button _button)
                {
                    if (_button.Name != button.Name)
                    {
                        switch (_button.Name)
                        {
                            case "ButtonMembers":
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonDues":
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonPayments":
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonMail":
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonHome":
                                _button.BackColor = Color.White;
                                break;
                        }
                    }
                    else
                    {
                        switch (_button.Name)
                        {
                            case "ButtonMembers":
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonDues":
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonPayments":
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonMail":
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonHome":
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                        }
                    }
                }
            }
        }
    }
}
