using CompRepair.Core.Services.EntityServices;
using CompRepair.WinFormsFrontend.Helpers.Fillers;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class ManufacturerComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var manufacturers = await new ManufacturerService().GetAllAsync();
        comboBox.Items.Clear();
        manufacturers.ForEach(manufacturer => comboBox.Items.Add(manufacturer.Name));
    }
}