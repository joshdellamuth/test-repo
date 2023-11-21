//using SQLite;
//using System.Security.Cryptography.X509Certificates;

//namespace GoalsApp.Models;

//public class MyTask
//{
//	[PrimaryKey,AutoIncrement]
//	public int Id { get; set; }
//	public string Name { get; set; }
//	public string Description { get; set; }
//}

//public class SQLiteDbContext
//{
//	const string DatabaseFileName = "sqlitedatabase.db3";
//	static string DataBasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);
//	const SQLite.SQLiteOpenFlags Flags =
//							SQLite.SQLiteOpenFlags.ReadWrite |
//							SQLite.SQLiteOpenFlags.Create |
//							SQLite.SQLiteOpenFlags.SharedCache;


//	SQLiteAsyncConnection Database;

//	async Task Init()
//	{
//		if(DatabaseFileName is not null)
//		{
//			return;
//		}
//		var result = await Database.CreateTableAsync<MyTask>();
//	}

//	public async Task<List<MyTask>> GetAllTasks()
//	{
//		await Init();
//		return await Database.Table<MyTask>().ToListAsync();
//	}

//	public async Task<MyTask> GetMyTaskAsync(int taskId)
//	{
//		await Init();
//		return await Database.Table<MyTask>().Where(p=>p.Id == taskId).FirstOrDefaultAsync();
//	}

//	//public async Task<>
//}