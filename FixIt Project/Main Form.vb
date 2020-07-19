' Name:         Course Info Project
' Purpose:      Display all records or only those for a specific grade.
' Programmer:   Austin Parker // Date: July 19, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCoursesDataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.MyCoursesDataSet.Courses)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display all records or only those for a specific grade.

        If radAll.Checked Then
            CoursesTableAdapter.Fill(MyCoursesDataSet.Courses)
            txtGrade.Text = String.Empty
            lblCount.Text = String.Empty
        Else
            If txtGrade.Text.Trim = String.Empty Then
                MessageBox.Show("Please enter the grade.", "Course Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CoursesTableAdapter.FillByGrade(MyCoursesDataSet.Courses, txtGrade.Text.Trim)
                NumGradeTableAdapter.FillNumGrade(MyCoursesDataSet.NumGrade)

                'Counts how many rows are displayed based on selected grade
                lblCount.Text = CoursesDataGridView.Rows.Count.ToString()

            End If
        End If
    End Sub

    Private Sub radAll_Click(sender As Object, e As EventArgs) Handles radAll.Click
        txtGrade.Text = String.Empty
        lblCount.Text = String.Empty
    End Sub

    Private Sub lblCount_Click(sender As Object, e As EventArgs) Handles lblCount.Click

    End Sub

    Private Sub CoursesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CoursesDataGridView.CellContentClick

    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged

    End Sub
End Class
