using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class OrderStatusFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var statuses = await new OrderStatusService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var status in statuses)
            {
                dataGridView.Rows.Add(
                    status.Id,
                    status.Name
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}