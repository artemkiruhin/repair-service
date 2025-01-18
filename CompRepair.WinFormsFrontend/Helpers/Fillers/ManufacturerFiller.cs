using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class ManufacturerFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var manufacturers = await new ManufacturerService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var manufacturer in manufacturers)
            {
                dataGridView.Rows.Add(
                    manufacturer.Id,
                    manufacturer.Name
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}