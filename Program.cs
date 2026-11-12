using Npgsql;
using Dapper;

string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
string connString = $"Host=localhost;Username=postgres;Password={password};Database=PersonDetailsDb";

using var conn = new NpgsqlConnection(connString);

var people = conn.Query("SELECT * FROM persondetails LIMIT 10");

foreach (var p in people)
    Console.WriteLine($"{p.id} {p.first_name} {p.last_name} {p.email} {p.gender}");