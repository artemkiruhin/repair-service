using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class CategoryComboBoxFiller
{
    public async Task FillComboBox(ComboBox comboBox)
    {
        var categories = await new CategoryService().GetAllAsync();
        comboBox.Items.Clear();
        categories.ForEach(category => comboBox.Items.Add(category.Name));
    }
}