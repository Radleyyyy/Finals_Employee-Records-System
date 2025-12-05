Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub LoadData()
        Try
            Dim sql As String = "SELECT id, name, position, salary, department FROM employees WHERE is_deleted = 0"
            Dim cmd As New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DatGridViewEmployees.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        TextBoxName.Clear()
        TextBoxPosition.Clear()
        TextBoxSalary.Clear()
        TextBoxDepartment.Clear()

    End Sub

    Private Sub DataGridViewEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatGridViewEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DatGridViewEmployees.Rows(e.RowIndex)

            TextBoxName.Text = row.Cells("name").Value.ToString()
            TextBoxPosition.Text = row.Cells("position").Value.ToString()
            TextBoxSalary.Text = row.Cells("salary").Value.ToString()
            TextBoxDepartment.Text = row.Cells("department").Value.ToString()
        End If
    End Sub


    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click

        If String.IsNullOrWhiteSpace(TextBoxName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPosition.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxSalary.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxDepartment.Text) Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        If Not Decimal.TryParse(TextBoxSalary.Text, New Decimal()) Then
            MessageBox.Show("Salary must be a number.")
            Return
        End If

        Try
            Dim query As String = "INSERT INTO employeerecordsystem (name, position, salary, department) VALUES (@Name, @Position, @Salary, @Department)"

            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_record_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@Position", (TextBoxPosition.Text))
                    cmd.Parameters.AddWithValue("@Salary", TextBoxSalary.Text)
                    cmd.Parameters.AddWithValue("@Department", TextBoxDepartment.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successfully!")
                End Using
            End Using


        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If DatGridViewEmployees.CurrentRow Is Nothing Then
            MsgBox("Please select a row first.")
            Exit Sub
        End If

        Dim selectedID As Integer = DatGridViewEmployees.CurrentRow.Cells("id").Value
        Dim query As String = "UPDATE employeerecordsystem SET name=@name, position=@position, salary=@salay, department=@department WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_record_system")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@position", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", TextBoxSalary.Text)
                    cmd.Parameters.AddWithValue("@department", TextBoxDepartment.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Updated Successfully")
                    TextBoxName.Clear()
                    TextBoxPosition.Clear()
                    TextBoxSalary.Clear()
                    TextBoxDepartment.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LoadData()
    End Sub


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DatGridViewEmployees.CurrentRow Is Nothing Then
            MsgBox("there is no item left")
            Exit Sub
        End If

        Dim selectedID As Integer = DatGridViewEmployees.CurrentRow.Cells("id").Value

        Dim query As String = "DELETE FROM employeerecordsystem WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_record_system")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record Deleted Successfully")
                    TextBoxName.Clear()
                    TextBoxPosition.Clear()
                    TextBoxSalary.Clear()
                    TextBoxDepartment.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        LoadData()
    End Sub

    Private Sub Mysql_Click(sender As Object, e As EventArgs) Handles Mysql.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=employee_record_system;"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM employeerecordsystem;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_record_system")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DatGridViewEmployees.DataSource = table
                DatGridViewEmployees.Columns("id").Visible = False
                TextBoxName.Clear()
                TextBoxPosition.Clear()
                TextBoxSalary.Clear()
                TextBoxDepartment.Clear()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class


