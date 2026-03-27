Imports System.Data.OleDb
Public Class frmConnectPage
    Public CurrentUserID As Integer ' Use this globally

    Private Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb;"


    Private Sub SendConnectionRequest(senderID As Integer, receiverID As Integer)
        ' Check if request already exists
        Dim checkSql As String = "SELECT COUNT(*) FROM tblConnections WHERE SenderID = ? AND ReceiverID = ?"
        Dim insertSql As String = "INSERT INTO tblConnections (SenderID, ReceiverID, Status, RequestDate) VALUES (?, ?, ?, ?)"

        ' Replace with your actual connection string
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb;")
            conn.Open()

            ' First, check if already sent
            Using checkCmd As New OleDbCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("?", senderID)
                checkCmd.Parameters.AddWithValue("?", receiverID)

                Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Request already sent!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End Using

            ' Insert request
            Using insertCmd As New OleDbCommand(insertSql, conn)
                insertCmd.Parameters.Add("?", OleDbType.Integer).Value = senderID            ' Number
                insertCmd.Parameters.Add("?", OleDbType.Integer).Value = receiverID          ' Number
                insertCmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Pending"           ' Short Text
                insertCmd.Parameters.Add("?", OleDbType.Date).Value = Date.Now            ' Date/Time

                insertCmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Request sent!", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnConnect1_Click(sender As Object, e As EventArgs) Handles btnConnect1.Click
        Dim btn As Button = CType(sender, Button)
        Dim receiverID As Integer = CInt(btn.Tag)

        ' Send connection request
        SendConnectionRequest(CurrentUserID, receiverID)

        btn.Text = "Pending"
        btn.Enabled = False
    End Sub

    Private Sub btnConnect2_Click(sender As Object, e As EventArgs) Handles btnConnect2.Click
        Dim btn As Button = CType(sender, Button)
        Dim receiverID As Integer = CInt(btn.Tag)

        ' Send connection request
        SendConnectionRequest(CurrentUserID, receiverID)

        btn.Text = "Pending"
        btn.Enabled = False
    End Sub

    Private Sub btnConnect3_Click(sender As Object, e As EventArgs) Handles btnConnect3.Click
        Dim btn As Button = CType(sender, Button)
        Dim receiverID As Integer = CInt(btn.Tag)

        ' Send connection request
        SendConnectionRequest(CurrentUserID, receiverID)

        btn.Text = "Pending"
        btn.Enabled = False
    End Sub

    Private Sub btnConnect4_Click(sender As Object, e As EventArgs) Handles btnConnect4.Click
        Dim btn As Button = CType(sender, Button)
        Dim receiverID As Integer = CInt(btn.Tag)

        ' Send connection request
        SendConnectionRequest(CurrentUserID, receiverID)

        btn.Text = "Pending"
        btn.Enabled = False
    End Sub

    Private Sub frmConnectPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadSuggestedUsers()
    End Sub

    Private Sub LoadSuggestedUsers()
        Dim usersTable As New DataTable()

        Dim query As String = "
        SELECT TOP 4 * FROM SignupLoginPage 
        WHERE ID <> ? 
        AND ID NOT IN (
            SELECT ReceiverID FROM tblConnections WHERE SenderID = ?
        )
    "

        Using conn As New OleDbConnection(CONNECTION_STRING)
            conn.Open()

            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", CurrentUserID)
                cmd.Parameters.AddWithValue("?", CurrentUserID)

                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(usersTable)
                End Using
            End Using
        End Using

        ' ✅ Manually assign each card
        If usersTable.Rows.Count > 0 Then
            lblName1.Text = usersTable.Rows(0)("userFullName").ToString()
            btnConnect1.Tag = usersTable.Rows(0)("ID")
            AddHandler btnConnect1.Click, AddressOf btnConnect1_Click
        Else
            lblName1.Text = "No suggestion"
            btnConnect1.Enabled = False
        End If

        If usersTable.Rows.Count > 1 Then
            lblName2.Text = usersTable.Rows(1)("userFullName").ToString()
            btnConnect2.Tag = usersTable.Rows(1)("ID")
            AddHandler btnConnect2.Click, AddressOf btnConnect2_Click
        Else
            lblName2.Text = "No suggestion"
            btnConnect2.Enabled = False
        End If

        If usersTable.Rows.Count > 2 Then
            lblName3.Text = usersTable.Rows(2)("userFullName").ToString()
            btnConnect3.Tag = usersTable.Rows(2)("ID")
            AddHandler btnConnect3.Click, AddressOf btnConnect3_Click
        Else
            lblName3.Text = "No suggestion"
            btnConnect3.Enabled = False
        End If

        If usersTable.Rows.Count > 3 Then
            lblName4.Text = usersTable.Rows(3)("userFullName").ToString()
            btnConnect4.Tag = usersTable.Rows(3)("ID")
            AddHandler btnConnect4.Click, AddressOf btnConnect4_Click
        Else
            lblName4.Text = "No suggestion"
            btnConnect4.Enabled = False
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)

        If clickedButton.Tag IsNot Nothing Then
            Dim receiverID As Integer = CInt(clickedButton.Tag)
            Dim senderID As Integer = CurrentUserID ' Replace with your actual variable or SessionData.LoggedInUserID

            ' 🔁 Send the request
            SendConnectionRequest(senderID, receiverID)

            ' 🔄 Refresh the list after sending
            LoadSuggestedUsers()
        End If
    End Sub


End Class