Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form1

    Private conn As New MySqlConnection("server=localhost;userid=root;password=root;database=employeerecordsystem;")
    Private selectedId As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DatGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DatGridViewEmployees.AllowUserToAddRows = False
        DatGridViewEmployees.ReadOnly = True

        LoadData()
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
        selectedId = -1
    End Sub

    Private Sub DataGridViewEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatGridViewEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DatGridViewEmployees.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)
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
            Dim sql As String = "INSERT INTO employees (name, position, salary, department) VALUES (@n, @p, @s, @d)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@n", TextBoxName.Text.Trim())
            cmd.Parameters.AddWithValue("@p", TextBoxPosition.Text.Trim())
            cmd.Parameters.AddWithValue("@s", Decimal.Parse(TextBoxSalary.Text.Trim()))
            cmd.Parameters.AddWithValue("@d", TextBoxDepartment.Text.Trim())

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Employee added.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If selectedId = -1 Then
            MessageBox.Show("Select a record first.")
            Return
        End If

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
            Dim sql As String = "UPDATE employees SET name=@n, position=@p, salary=@s, department=@d WHERE id=@id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@n", TextBoxName.Text.Trim())
            cmd.Parameters.AddWithValue("@p", TextBoxPosition.Text.Trim())
            cmd.Parameters.AddWithValue("@s", Decimal.Parse(TextBoxSalary.Text.Trim()))
            cmd.Parameters.AddWithValue("@d", TextBoxDepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@id", selectedId)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Employee updated.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Update error: " & ex.Message)
        End Try
    End Sub


    Private Sub ButtonDelete1_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        If selectedId = -1 Then
            MessageBox.Show("Select a record first.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            Dim sql As String = "UPDATE employees SET is_deleted = 1 WHERE id=@id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", selectedId)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Employee deleted.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub



    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        LoadData()
    End Sub


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        ClearFields()
    End Sub

End Class


