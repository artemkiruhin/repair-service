using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class DeviceTypeComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var types = await new DeviceTypeService().GetAllAsync();
        comboBox.Items.Clear();
        types.ForEach(type => comboBox.Items.Add(type.Name));
    }
}