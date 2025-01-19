using CompRepair.Core.Models.Entities;

namespace CompRepair.WinFormsFrontend.Helpers.ComboBoxFillers;

public class LogTypeFiller
{
    public void FillComboBox(ComboBox comboBox)
    {
        comboBox.Items.Clear();
        
        comboBox.Items.Add(nameof(LogType.Info));
        comboBox.Items.Add(nameof(LogType.Warn));
        comboBox.Items.Add(nameof(LogType.Error));
    }
}