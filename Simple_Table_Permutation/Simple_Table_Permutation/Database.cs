using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public class Database
    {
        private readonly string dataSource;

        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }

        public bool InitializeDatabase()
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                   + "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,"
                   + "username TEXT NOT NULL,"
                   + "login TEXT NOT NULL, "
                   + "password TEXT NOT NULL, "
                   + "role TEXT NOT NULL " 
                   + "data TEXT)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return true;
        }

        public int UsersCount()
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    string sql_command = "SELECT count(id) FROM users";
                    cmd.CommandText = sql_command;
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return -1;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return -1;
        }

        public bool AddUser(string username, string login, string passwordHASH, string role)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "INSERT INTO users(username, login, password, role) VALUES ( @username, @login, @password, @role)";
                    cmd.Parameters.Add("@username", DbType.String).Value = username;
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    cmd.Parameters.Add("@password", DbType.String).Value = passwordHASH;
                    cmd.Parameters.Add("@role", DbType.String).Value = role;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return true;
        }

        public bool ValidUser(string login, string passwordHASH)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login = @login AND password = @password";
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    cmd.Parameters.Add("@password", DbType.String).Value = passwordHASH;
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount >= 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return false;
        }

        public User GetUserData(string login, string passwordHASH)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login = @login AND password = @password";
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    cmd.Parameters.Add("@password", DbType.String).Value = passwordHASH;
                    SQLiteDataReader sql_reader = cmd.ExecuteReader();

                    if (sql_reader.Read())
                    {
                        User user = new User(sql_reader["id"].ToString(), sql_reader["username"].ToString(), sql_reader["login"].ToString(), sql_reader["password"].ToString(), sql_reader["role"].ToString());
                        return user;
                    }
                    else
                        return new User();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return new User();
        }

        public bool GetLoginState(string login)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login = @login";
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return false;
        }

        public bool UpdateUserPassword(string login, string newPasswordHASH)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "UPDATE users SET password = @password WHERE login = @login";
                    cmd.Parameters.Add("@password", DbType.String).Value = newPasswordHASH;
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return true;
        }

        public bool SaveData(string login, string data)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "UPDATE users SET data = @data WHERE login = @login";
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    cmd.Parameters.Add("@data", DbType.String).Value = data;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
                return false;
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return true;
        }

        public string ReadData(string login)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(dataSource);
            try
            {
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login = @login";
                    cmd.Parameters.Add("@login", DbType.String).Value = login;
                    SQLiteDataReader sql_reader = cmd.ExecuteReader();
                    if (sql_reader.Read())
                        return sql_reader["data"].ToString();
                    else
                        return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite error: " + ex.Message);
            }
            finally
            {
                sQLiteConnection.Dispose();
            }
            return string.Empty;
        }
    }
}
