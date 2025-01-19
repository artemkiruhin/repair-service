using CompRepair.Core.Services;

namespace CompRepair.WinFormsFrontend.Helpers.Fillers;

public class LogFiller
{
    public async Task FillDataGridView(DataGridView dataGridView)
    {
        try
        {
            var logs = await new Logger().GetAllAsync(); 

            dataGridView.Rows.Clear();
        
            foreach (var log in logs)
            {
                dataGridView.Rows.Add(
                    log.Id,
                    log.CreatedAt,
                    log.UserId.HasValue ? log.UserId.Value.ToString() : "",
                    log.Message,
                    log.LogType
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Внутренняя ошибка при заполнени таблицы");
        }
    }
}