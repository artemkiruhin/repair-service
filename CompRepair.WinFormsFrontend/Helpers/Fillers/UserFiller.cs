using CompRepair.Core.Services.EntityServices;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class UserFiller
{
    
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var users = await new UserService().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var user in users)
            {
                dataGridView.Rows.Add(
                    user.Id,
                    user.Username,
                    user.FullName,
                    user.Email,
                    user.Phone,
                    user.Salary,
                    user.HiredDate,
                    user.FiredDate,
                    user.BirthDate,
                    user.Role
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}