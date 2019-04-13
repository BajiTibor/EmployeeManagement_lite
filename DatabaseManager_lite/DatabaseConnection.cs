using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseManager_lite
{
    public class DatabaseConnection
    {
        private readonly Random _rng = new Random();
        private readonly CorrectDate _modifyDate = new CorrectDate();
        private List<int> TakenIdList { get; }
        private MySqlCommand _command;
        private MySqlConnection _connection;
        private MySqlDataAdapter _adapter;
        private DataTable _dataTable;
        private readonly string _connectionString;

        public DatabaseConnection(string server, string id, string password)
        {
            var defaultString = $"server={server};user id={id};password={password}";
            _connectionString = defaultString;
            TakenIdList = new List<int>();
            _connection = new MySqlConnection(defaultString);
        }

        public async Task<DataTable> GetTable(string limit, string isNull = "")
        {
            var sql = $"SELECT * FROM dolgozokSC.data WHERE kilep_datum IS {isNull} NULL LIMIT {limit};";

            _dataTable = await FillTable(sql);

            foreach (DataRow id in _dataTable.Rows) TakenIdList.Add(int.Parse(id["ID"].ToString()));

            return _dataTable;
        }

        public async Task<DataTable> GetNameSearch(string limit, string name, string isNull = "")
        {
            var sql =
                $"SELECT * FROM dolgozokSC.data WHERE nev LIKE \"%{name}%\" AND kilep_datum IS {isNull} NULL LIMIT {limit};";

            _dataTable = await FillTable(sql);

            return _dataTable;
        }

        public async Task<DataTable> GetFromTo(string limit, string isNull, DateTime fromPassed, DateTime toPassed)
        {
            var from = _modifyDate.CorrectDateTime(fromPassed);
            var to = _modifyDate.CorrectDateTime(toPassed);

            var sql =
                $"SELECT * FROM dolgozoksc.data WHERE belepes BETWEEN \"{from}\" AND \"{to}\" AND kilep_datum IS {isNull} NULL LIMIT {limit};";

            _dataTable = await FillTable(sql);

            return _dataTable;
        }

        public async void CreateSchema()
        {
            const string sql = @"CREATE SCHEMA dolgozokSC DEFAULT CHARACTER SET utf8 COLLATE
                          utf8_hungarian_ci; CREATE TABLE dolgozokSC.data (
                          id INT NOT NULL AUTO_INCREMENT, nev VARCHAR(45) NOT NULL,
                          szulido DATE NOT NULL, telszam VARCHAR(17) NOT NULL,
                          vegzettseg VARCHAR(20) NOT NULL, szakma VARCHAR(45) NOT NULL,
                          belepes DATE NOT NULL, statusz VARCHAR(20) NOT NULL,
                          modositas DATE NULL, kilep_datum DATE NULL, 
                          PRIMARY KEY (id));";

            await ExecuteQuery(sql);
        }

        public async void InsertNewRow(Employee employee)
        {
            int newId;
            do
            {
                newId = _rng.Next(100000, 999999);
            } while (TakenIdList.Contains(newId));

            TakenIdList.Add(newId);

            var sql =
                $"INSERT INTO dolgozokSC.data VALUES ({newId}, \"{employee.Name}\", \"{employee.BirthDate}\"," +
                $" \"{employee.Phone}\", \"{employee.Education}\", \"{employee.Profession}\"," +
                $" \"{_modifyDate.CurrentDate()}\", \"{employee.State}\", \"{_modifyDate.CurrentDate()}\", NULL);";

            await ExecuteQuery(sql);
        }

        public async Task<bool> TableExists()
        {
            _connection = new MySqlConnection(_connectionString);
            var sql = "SELECT * FROM dolgozokSC.data";

            return await ExecuteQuery(sql);
        }

        public async void SetExit(int userId)
        {
            var sql = $"UPDATE dolgozokSC.data SET kilep_datum = \"{_modifyDate.CurrentDate()}\" WHERE ID = {userId}";

            await ExecuteQuery(sql);
        }

        public async void UpdateRecord(Employee employee)
        {
            var sql =
                $"UPDATE dolgozoksc.data SET nev=\"{employee.Name}\", szulido=\"{employee.BirthDate}\", telszam=\"{employee.Phone}\", " +
                $"vegzettseg=\"{employee.Education}\", szakma=\"{employee.Profession}\", statusz=\"{employee.State}\", modositas=\"{_modifyDate.CurrentDate()}\" " +
                $"WHERE ID ={employee.Id};";

            await ExecuteQuery(sql);
        }

        public async Task<bool> IsPasswordCorrect()
        { 
            try
            {
                await GetTable("1");
            }
            catch
            {
                return false;
            }

            return true;
        }

        private async Task<DataTable> FillTable(string sql)
        {
            _dataTable = new DataTable();
            await _connection.OpenAsync();
            try
            {
                _adapter = new MySqlDataAdapter(sql, _connection);
                await _adapter.FillAsync(_dataTable);
            }
            catch
            {
                Environment.Exit(1);
            }
            finally
            {
                await _connection.CloseAsync();
                _connection.Dispose();
            }

            return _dataTable;
        }

        private async Task<bool> ExecuteQuery(string sql)
        {
            _command = new MySqlCommand(sql, _connection);
            await _connection.OpenAsync();
            try
            {
                await _command.ExecuteNonQueryAsync();
            }
            catch
            {
                return false;
            }
            finally
            {
                await _connection.CloseAsync();
                _connection.Dispose();
            }

            return true;
        }
    }
}