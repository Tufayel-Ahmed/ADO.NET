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
