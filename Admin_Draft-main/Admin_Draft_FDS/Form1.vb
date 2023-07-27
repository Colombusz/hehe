Imports MySql.Data.MySqlClient

Public Class payrollWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, histB.Click
        Dim statement As String = "SELECT u.id AS EMPLOYEE_ID,u.username,  u.first_name, s.id AS Salary_id , uhs.payGrade , s.hoursWorked,b.id AS Benefits_id, b.pagIbig, b.sss, b.philHealth, s.gross_amount, s.net_amount AS Total
                                    FROM user AS u
                                    JOIN user_has_salary AS uhs ON uhs.user_id = u.id
                                    JOIN salary AS s ON s.id = uhs.salary_id
                                    JOIN benefits AS b ON b.id = s.benefits_id
                                    ORDER BY u.id ASC;"

        DataGridView1.DataSource = dtablefill(statement)
    End Sub


End Class