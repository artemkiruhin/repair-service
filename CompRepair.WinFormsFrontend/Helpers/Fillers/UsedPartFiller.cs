using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class UsedPartFiller
{
    
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var usedParts = await new UsedPartService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var usedPart in usedParts)
            {
                dataGridView.Rows.Add(
                    usedPart.Id,
                    usedPart.Quantity,
                    usedPart.PricePerPart,
                    usedPart.PartId,
                    usedPart.PartName,
                    usedPart.RepairOrderId
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}