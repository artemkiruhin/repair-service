using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class ClientComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var clients = await new ClientService().GetAllAsync();
        comboBox.Items.Clear();
        clients.ForEach(client => comboBox.Items.Add($"{client.FullName} - {client.Phone}"));
    }
}