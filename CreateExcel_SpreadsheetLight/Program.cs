using SpreadsheetLight;

string pathFile = AppDomain.CurrentDomain.BaseDirectory + "myExcel.xlsx";

SLDocument oSLDocument = new SLDocument();

System.Data.DataTable dt = new System.Data.DataTable();


//Add Columns
dt.Columns.Add("Name", typeof(string));
dt.Columns.Add("Age", typeof(int));
dt.Columns.Add("Gender", typeof(string));

