using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class RepairOrderFiller
{
    
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var orders = await new RepairOrderService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var order in orders)
            {
                dataGridView.Rows.Add(
                    order.SerialNumber,
                    order.ClientFullName,
                    order.ClientPhone,
                    order.ClientEmail,
                    order.TechnicianId,
                    order.TechnicianFullName,
                    order.TechnicianPhone,
                    order.TechnicianEmail,
                    order.TechnicianUsername,
                    order.DeviceTypeName,
                    order.Problem,
                    order.Diagnosis,
                    order.Status,
                    order.EstimatedCost,
                    order.FinalCost ?? -1,
                    order.CompletedAt.HasValue ? order.CompletedAt.Value.ToShortDateString() : "" 
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}