# ADO.NET
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
<h3>SqlConnection class constructors</h3> 
<p>1.	SqlConnection(): It initializes a new instance of the SqlConnection class</p>
<p>2.	SqlConnection(String connectionString): This constructor is used to initializes a new instance of the SqlConnection class when given a string that contains the connection string.</p>
<p>3.	SqlConnection(String connectionString, SqlCredential credential): It is used to initializes a new instance of the SqlConnection class given a connection string, that uses Integrated Security = false.</p>
<h3>SqlConnection class Methods</h3>
<p>1.	BeginTransaction(): It is used to start a database transaction and returns an object representing the new transaction.</p>
<p>2.	ChangeDatabase(string database): It is used to change the current database for an open SqlConnection.</p>
<p>3.	ChangePassword(string connectionString, string newPassword): Changes the SQL Server password for the user indicated in the connection string to the supplied new password. The connection string must contain the user ID and the current password.</p>
<p>4.	Close(): It is used to closes the connection to the database.</p>
<p>5.	CreateCommand(): It Creates and returns a SqlCommand object associated with the SqlConnection.</p>
<p>6.	GetSchema(): It returns schema information for the data source of this SqlConnection.</p>
<p>7.	Open(): This method is used to open a database connection.</p>

