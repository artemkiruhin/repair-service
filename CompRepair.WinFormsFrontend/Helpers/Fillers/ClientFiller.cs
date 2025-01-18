using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class ClientFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var clients = await new ClientService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var client in clients)
            {
                foreach (var order in client.RepairOrders)
                {
                    foreach (var part in order.UsedParts)
                    {
                        dataGridView.Rows.Add(
                            client.Id, 
                            client.FullName, 
                            client.Email, 
                            client.Phone, 
                            client.BirthDate?.ToShortDateString() ?? "",
                            order.SerialNumber,
                            order.Problem,
                            order.Diagnosis,
                            order.Status,
                            part.PartName,
                            part.Quantity,
                            part.PricePerPart
                        );
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }

}