#r "nuget: Fsharp.Data"
#r "nuget: System.Data.SqlClient"
#r "nuget: SQLProvider"

open FSharp.Data.Sql
open System.Data.SqlClient

type sql = SqlDataProvider< 
            ConnectionString = "Server=localhost,1433;Initial Catalog=TestDb;User ID=sa;Password=Strong!Passw0rd;MultipleActiveResultSets=True;Connection Timeout=30;",
            DatabaseVendor = Common.DatabaseProviderTypes.MSSQLSERVER,
            UseOptionTypes = true>

let db = sql.GetDataContext().Dbo
let students =
    query {
        for student in db.Student do
        where (student.Age >= 10 && student.Age < 25)
        select student
    }
(students |> Seq.head).Name |> printf "First student name is %s"