using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class CategoryFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var categories = await new CategoryService().GetAllAsync(); 
            
            dataGridView.Rows.Clear();
        
            foreach (var category in categories)
            {
                dataGridView.Rows.Add(
                    category.Id,
                    category.Name
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }

}