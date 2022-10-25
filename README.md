# ADO.NET
<div align="justify">
In this repository, I am going to cover all most all the concepts of ADO.NET such as SQL Server database, working with XML Document, Understanding connected and disconnected architecture, SQL Bulk Copy, SQL Injection, and its Prevention, Transactions in ADO.NET, etc.
<h3>Introduction to ADO.NET</h3>
<p>ADO stands for Microsoft ActiveX Data Objects. ADO.NET is one of Microsoft’s Data Access technology using which we can communicate with different data sources. It is a part of the .Net Framework which is used to establish a connection between the .NET Application and data sources. The Data sources can be consists of a set of classes that can be used to performing CRUD operation from data sources. ADO.NET mainly uses System.Data.dll and System.Xml.dll.</p>
<h3>Types of Applications use ADO.NET</h3>
<p>1.	ASP.NET Web Form Applications</p>
<p>2.	Windows Applications</p>
<p>3.	ASP.NET MVC Application</p>
<p>4.	Console Applications</p>
<p>5.	ASP.NET Web API Applications</p>
<h3>Components of ADO.NET</h3>
<p>Components are designed for data manipulation and faster data access. They are as follows:</p>
<p>1.	Data Provider: The Database cannot directly execute our C# code, it only understands SQL. So, if a .NET application needs to retrieve data or to do some insert, update, and delete operations from or to a database, then the .NET application needs some classes such as SQLConnection, SQLCommand, and SQLDataReader, SQLDataAdapter. These classes are called Data Provider classes. The .NET data provider for the SQL Server database is System.Data.SqlClient.</p>
<p>2.	DataSet: The DataSet contains a collection of one or more DataTable objects. It is used to access data independently from any data source.</p>
<h3>SqlConnection Class</h3>
<p>The ADO.NET SqlConnection class belongs to System.Data.SqlClient namespace and is used to establish an open connection to the SQL Server database. The connections should be opened as late as possible, and should be closed as early as possible as the connection is one of the most expensive resources. It is a sealed class and inherited from DbConnection class and implement the ICloneable interface.</p>
<h3>SqlConnection Class Constructors</h3> 
<p>1.	SqlConnection(): It initializes a new instance of the SqlConnection class</p>
<p>2.	SqlConnection(String connectionString): This constructor is used to initializes a new instance of the SqlConnection class when given a string that contains the connection string.</p>
<p>3.	SqlConnection(String connectionString, SqlCredential credential): It is used to initializes a new instance of the SqlConnection class given a connection string, that uses Integrated Security = false.</p>
<h3>SqlConnection Class Methods</h3>
<p>1.	BeginTransaction(): It is used to start a database transaction and returns an object representing the new transaction.</p>
<p>2.	ChangeDatabase(string database): It is used to change the current database for an open SqlConnection.</p>
<p>3.	ChangePassword(string connectionString, string newPassword): Changes the SQL Server password for the user indicated in the connection string to the supplied new password. The connection string must contain the user ID and the current password.</p>
<p>4.	Close(): It is used to closes the connection to the database.</p>
<p>5.	CreateCommand(): It Creates and returns a SqlCommand object associated with the SqlConnection.</p>
<p>6.	GetSchema(): It returns schema information for the data source of this SqlConnection.</p>
<p>7.	Open(): This method is used to open a database connection.</p>
<h3>SqlCommand Class</h3>
<p></p>The ADO.NET SqlCommand class in C# is used to store and execute the SQL statement against the SQL Server database. The SqlCommand class is a sealed class and is inherited from the DbCommand class and implement the ICloneable interface.
<h3>SqlCommand Class Constructors </h3>
<p>1.	SqlCommand(): This constructor is used to initializes a new instance of the SqlCommand class.</p>
<p>2.	SqlCommand(string cmdText): It is used to initializes a new instance of the SqlCommand class with the text of the query.</p>
<p>3.	SqlCommand(string cmdText, SqlConnection connection): It is used to initializes a new instance of the SqlCommand class with the text of the query and a SqlConnection.</p>
<p>4.	SqlCommand(string cmdText, SqlConnection connection, SqlTransaction transaction): It is used to initializes a new instance of the SqlCommand class with the text of the query, a SqlConnection instance, and the SqlTransaction instance.</p>
<p>5.	SqlCommand(string cmdText, SqlConnection connection, SqlTransaction transaction, SqlCommandColumnEncryptionSetting columnEncryptionSetting): It is used to initializes a new instance of the SqlCommand class with specified command text, connection, transaction, and encryption setting.</p>
<h3>SqlCommand Class Methods</h3>
<p>1.	BeginExecuteNonQuery(): This method initiates the asynchronous execution of the Transact-SQL statement or stored procedure that is described by this SqlCommand.</p>
<p>2.	Cancel(): This method tries to cancel the execution of a SqlCommand.</p>
<p>3.	Clone(): This method creates a new SqlCommand object is a copy of the current instance.</p>
<p>4.	CreateParameter(): This method creates a new instance of a SqlParameter object.</p>
<p>5.	ExecuteReader(): This method Sends the SqlCommand.CommandText to the SqlCommand.Connection and builds a SqlDataReader.</p>
<p>6.	ExecuteScalar(): This method Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored.</p>
<p>7.	ExecuteNonQuery(): This method executes a Transact-SQL statement against the connection and returns the number of rows affected.</p>
<p>8.	Prepare(): This method creates a prepared version of the command on an instance of SQL Server.</p>
<p>9.	ResetCommandTimeout(): This method resets the CommandTimeout property to its default value.</p>
<h3></h3>SqlDataReader Class
<p>The ADO.NET SqlDataReader class in C# is used to read data from the SQL Server database in the most efficient manner. It reads data in the forward-only direction. It means, once it read a record, it will then read the next record, there is no way to go back and read the previous record. The SqlDataReader is connection-oriented. It means it requires an open or active connection to the data source while reading the data. The data is available as long as the connection with the database exists. This class is inherited from DbDataReader class and implements the IDataReader, IDisposable, IDataRecord interface.</p>
<h3>SqlDataReader Class Properties</h3>
<p>1.	Connection: It gets the SqlConnection associated with the SqlDataReader.</p>
<p>2.	Depth: It gets a value that indicates the depth of nesting for the current row.</p>
<p>3.	FieldCount: It gets the number of columns in the current row.</p>
<p>4.	HasRows: It gets a value that indicates whether the SqlDataReader contains one or more rows.</p>
<p>5.	IsClosed: It retrieves a Boolean value that indicates whether the specified SqlDataReader instance has been closed.</p>
<p>6.	RecordsAffected: It gets the number of rows changed, inserted, or deleted by the execution of the Transact-SQL statement.</p>
<p>7.	VisibleFieldCount: It gets the number of fields in the SqlDataReader that is not hidden.</p>
<p>8.	Item[String]: It gets the value of the specified column in its native format given the column name.</p>
<p>9.	Item[Int32]: It gets the value of the specified column in its native format given the column ordinal.</p>
<h3>SqlDataReader Class Methods</h3>
<p>1.	Close(): It closes the SqlDataReader object.</p>
<p>2.	GetBoolean(int i): It gets the value of the specified column as a Boolean. </p>
<p>3.	GetByte(int i): It gets the value of the specified column as a byte.</p>
<p>4.	GetChar(int i): It gets the value of the specified column as a single character.</p>
<p>5.	GetDateTime(int i): It gets the value of the specified column as a DateTime object.</p>
<p>6.	GetDecimal(int i): It gets the value of the specified column as a Decimal object. </p>
<p>7.	GetDouble(int i): It gets the value of the specified column as a double-precision floating-point number.</p>
<p>8.	GetFloat(int i): It gets the value of the specified column as a single-precision floating-point number.</p>
<p>9.	GetName(int i): It gets the name of the specified column.</p>
<p>10.	GetSchemaTable(): It returns a DataTable that describes the column metadata of the SqlDataReader</p>
<p>11.	GetValue(int i): It gets the value of the specified column in its native format.</p>
<p>12.	GetValues(object[] values): It Populates an array of objects with the column values of the current row.</p>
<p>13.	NextResult(): It advances the data reader to the next result when reading the results of batch Transact-SQL statements.</p>
<p>14.	Read(): It Advances SqlDataReader to the next record and returns true if there are more rows; otherwise false.</p>
</div>
