using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using WorkersCatalog.Model;
using WorkersCatalog.Controller;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkersCatalog.Database
{
    class DatabaseProvider
    {
        private static DatabaseProvider instance;

        public static DatabaseProvider Instance
        {
            get
            {
                if (instance == null) instance = new DatabaseProvider();
                return instance;
            }
        }
        private DatabaseProvider() { }

        private SqlConnectionStringBuilder connectionString;
        public void Initialize(string user, string password, string database)
        {
            connectionString = new SqlConnectionStringBuilder();     //using System.Data.Common; 
            connectionString.DataSource = "IVAN\\SQLEXPRESS";
            connectionString.InitialCatalog = database;
            connectionString.IntegratedSecurity = true;
            //cs.Password
            //cs.UserID
        }
        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString.ConnectionString;
            connection.Open();
            return connection;
        }

        public List<Item> GetWorkers()
        {
            var workers = new List<Item>();
            using (var connection = OpenConnection())
            {
                SqlCommand command = new SqlCommand("select * from worker;", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    workers.Add
                        (
                        new Item
                            (
                            int.Parse(reader["Id"].ToString()),
                            reader["Name"].ToString(),
                            reader["Surname"].ToString(),
                            reader["Position"].ToString(),
                            reader["Photo"] == System.DBNull.Value ? new BitmapImage(new Uri("../../View/no-thumb.png", UriKind.Relative)) : myByteArrayConverter((byte[])reader["Photo"]),
                            reader["DateOfBirth"].ToString().ToLower() == "null" ? new DateTime(1900, 1, 1) : DateTime.Parse(reader["DateOfBirth"].ToString()),
                            reader["ImploymentOrderNumber"].ToString(),
                            reader["ImploymentOrderDate"].ToString().ToLower() == "null" ? new DateTime(1900, 1, 1) : DateTime.Parse(reader["ImploymentOrderDate"].ToString()),
                            reader["FireOrderNumber"].ToString(),
                            new DateTime(1900, 1, 1)//reader["FireOrderDate"].ToString().ToLower() == "null" ? new DateTime(1900, 1, 1) : DateTime.Parse(reader["FireOrderDate"].ToString())
                            )
                        );
                }
            }
            return workers;
        }
        public void CreateNewData(string name, string surname, DateTime birthday, string position, string implOrderNumber, DateTime implOrderDate, string fireOrderNumber, DateTime fireOrderDate, string imagePath)
        {
            using (var connection = OpenConnection())
            {
                var com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "AddNewWorker";

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@name";
                nameParam.SqlDbType = SqlDbType.NVarChar;
                nameParam.Direction = ParameterDirection.Input;
                nameParam.Value = name;
                com.Parameters.Add(nameParam);

                SqlParameter surnameParam = new SqlParameter();
                surnameParam.ParameterName = "@surname";
                surnameParam.SqlDbType = SqlDbType.NVarChar;
                surnameParam.Direction = ParameterDirection.Input;
                surnameParam.Value = surname;
                com.Parameters.Add(surnameParam);

                SqlParameter birthdayParam = new SqlParameter();
                birthdayParam.ParameterName = "@dateOfBirth";
                birthdayParam.SqlDbType = SqlDbType.Date;
                birthdayParam.Direction = ParameterDirection.Input;
                birthdayParam.Value = birthday;
                com.Parameters.Add(birthdayParam);

                SqlParameter positionParam = new SqlParameter();
                positionParam.ParameterName = "@position";
                positionParam.SqlDbType = SqlDbType.NVarChar;
                positionParam.Direction = ParameterDirection.Input;
                positionParam.Value = position;
                com.Parameters.Add(positionParam);

                SqlParameter implOrderNumberParam = new SqlParameter();
                implOrderNumberParam.ParameterName = "@imploymentOrderNumber";
                implOrderNumberParam.SqlDbType = SqlDbType.NVarChar;
                implOrderNumberParam.Direction = ParameterDirection.Input;
                implOrderNumberParam.Value = implOrderNumber;
                com.Parameters.Add(implOrderNumberParam);

                SqlParameter implOrderDateParam = new SqlParameter();
                implOrderDateParam.ParameterName = "@imploymentOrderDate";
                implOrderDateParam.SqlDbType = SqlDbType.Date;
                implOrderDateParam.Direction = ParameterDirection.Input;
                implOrderDateParam.Value = implOrderDate;
                com.Parameters.Add(implOrderDateParam);

                SqlParameter fireOrderNumberParam = new SqlParameter();
                fireOrderNumberParam.ParameterName = "@fireOrderNumber";
                fireOrderNumberParam.SqlDbType = SqlDbType.NVarChar;
                fireOrderNumberParam.Direction = ParameterDirection.Input;
                fireOrderNumberParam.Value = fireOrderNumber;
                com.Parameters.Add(fireOrderNumberParam);

                SqlParameter fireOrderDateParam = new SqlParameter();
                fireOrderDateParam.ParameterName = "@fireOrderDate";
                fireOrderDateParam.SqlDbType = SqlDbType.Date;
                fireOrderDateParam.Direction = ParameterDirection.Input;
                fireOrderDateParam.Value = fireOrderDate;
                com.Parameters.Add(fireOrderDateParam);


                SqlParameter photoParam = new SqlParameter();
                photoParam.ParameterName = "@photo";
                photoParam.SqlDbType = SqlDbType.Image;
                photoParam.Direction = ParameterDirection.Input;
                byte[] data = myImageConverter(imagePath);
                photoParam.Value = data;
                com.Parameters.Add(photoParam);

                com.ExecuteNonQuery();
            }
        }
        public void EditData(int id, string name, string surname, DateTime birthday, string position, string implOrderNumber, DateTime implOrderDate, string fireOrderNumber, DateTime fireOrderDate, string imagePath)
        {
            using (var connection = OpenConnection())
            {
                var com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "UpdateWorlerData";

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@name";
                nameParam.SqlDbType = SqlDbType.NVarChar;
                nameParam.Direction = ParameterDirection.Input;
                nameParam.Value = name;
                com.Parameters.Add(new SqlParameter("@id",id));
                com.Parameters.Add(new SqlParameter("@name",name));
                com.Parameters.Add(new SqlParameter("@surname", surname));
                com.Parameters.Add(new SqlParameter("@dateOfBirth", birthday));
                com.Parameters.Add(new SqlParameter("@position", position));
                com.Parameters.Add(new SqlParameter("@imploymentOrderNumber", implOrderNumber));
                com.Parameters.Add(new SqlParameter("@imploymentOrderDate", implOrderDate));
                com.Parameters.Add(new SqlParameter("@fireOrderNumber", fireOrderNumber));
                com.Parameters.Add(new SqlParameter("@fireOrderDate", fireOrderDate));
                com.Parameters.Add(new SqlParameter("@photo", myImageConverter(imagePath)));

                com.ExecuteNonQuery();
            }
        }
        public void UpdeteData(int id, string login, string password)
        {
            using (var connection = OpenConnection())
            {
                var com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "UpdateData";
                SqlParameter loginParam = new SqlParameter();
                loginParam.ParameterName = "@login";
                loginParam.SqlDbType = SqlDbType.NVarChar;
                loginParam.Direction = ParameterDirection.Input;
                loginParam.Value = login;

                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.NVarChar);
                passwordParam.Direction = ParameterDirection.Input;
                passwordParam.Value = password;

                SqlParameter newId = new SqlParameter("@userId", id);
                newId.SqlDbType = SqlDbType.NVarChar;

                com.Parameters.Add(newId);
                com.Parameters.Add(loginParam);
                com.Parameters.Add(passwordParam);

                com.ExecuteNonQuery();

            }
        }

        public void DeleteData(int id)
        {
            using (var connection = OpenConnection())
            {
                var com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "DeleteWorker";
                SqlParameter newId = new SqlParameter("@id", id);
                newId.SqlDbType = SqlDbType.Int;
                com.Parameters.Add(newId);
                com.ExecuteNonQuery();
            }
        }
        
        private byte[] myImageConverter(string path)
        {
            ImageConverter _imageConverter = new ImageConverter();
            System.Drawing.Image x = System.Drawing.Image.FromFile(path);
            
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;

        }
        
        private BitmapImage myByteArrayConverter(byte[] array)
        {
            using (var ms = new System.IO.MemoryStream(array))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad; // here
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }
    }
}
