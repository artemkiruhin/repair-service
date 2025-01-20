using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class UserComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var users = await new UserService().GetAllAsync();
        comboBox.Items.Clear();
        users.ForEach(user => comboBox.Items.Add(user.Username));
    }
}