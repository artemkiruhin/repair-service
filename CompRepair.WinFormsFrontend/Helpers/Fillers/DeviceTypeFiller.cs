using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class DeviceTypeFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var types = await new DeviceTypeService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var type in types)
            {
                dataGridView.Rows.Add(
                    type.Id,
                    type.Name
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}