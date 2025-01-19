using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class PartFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var parts = await new PartService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var part in parts)
            {
                dataGridView.Rows.Add(
                    part.Id,
                    part.Name,
                    part.Description,
                    part.Price,
                    part.StockQuantity,
                    part.CategoryName,
                    part.ManufacturerName
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}