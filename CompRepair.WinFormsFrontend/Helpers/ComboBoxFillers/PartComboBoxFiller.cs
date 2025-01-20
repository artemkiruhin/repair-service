using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class PartComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var parts = await new PartService().GetAllAsync();
        comboBox.Items.Clear();
        parts.ForEach(part => comboBox.Items.Add(part.Name));
    }
}