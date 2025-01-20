using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class OrderStatusComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var statuses = await new OrderStatusService().GetAllAsync();
        comboBox.Items.Clear();
        statuses.ForEach(status => comboBox.Items.Add(status.Name));
    }
}