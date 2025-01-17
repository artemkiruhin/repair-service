using Microsoft.Extensions.Configuration;
using System.Text.Json;
using CompRepair.Core.Database;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services;

public class AuthService
{
    private static bool Save(Guid id)
    {
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var authTokenPath = Path.Combine(basePath, "Settings", "auth-token.json");

        Directory.CreateDirectory(Path.GetDirectoryName(authTokenPath)!);

        var tokenData = new { guid = id.ToString() };
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(tokenData, jsonOptions);

        File.WriteAllText(authTokenPath, jsonString);
        return true;
    }

    private static bool Delete()
    {
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var authTokenPath = Path.Combine(basePath, "Settings", "auth-token.json");
        if (File.Exists(authTokenPath)) File.Delete(authTokenPath);
        
        return true;
    }

    public async Task<bool> Login(string username, string password)
    {
        var database = new AppDbContext();
        var user = await database.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        if (user == null) throw new UnauthorizedAccessException();
        
        return Save(user.Id);
    }

    public bool Logout()
    {
        return Delete();
    }

    public Guid GetUserId()
    {
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var settingsPath = Path.Combine(basePath, "Settings", "auth-token.json");

        if (!File.Exists(settingsPath)) throw new FileNotFoundException();
        var jsonText = File.ReadAllText(settingsPath);
        var tokenData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonText);
        if (tokenData == null || !tokenData.ContainsKey("guid")) throw new InvalidOperationException();

        return Guid.Parse(tokenData["guid"]);
    }

    public async Task<bool> Register(string username, string fullName, string password, DateTime hiredDate,
        DateTime? firedDate, decimal salary, string phone, string email, DateTime birthDate,
        UserRole role = UserRole.Employee)
    {
        var service = new UserService();
        var result = await service.AddAsync(username, fullName, password, hiredDate, firedDate, salary, phone, email,
            birthDate, role);
        if (!result) throw new UnauthorizedAccessException();
        
        return true;
    }
}
