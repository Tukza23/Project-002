Imports MySql.Data.MySqlClient
Module deleteQuery

    ' deletes the product details
    Public Sub deleteProduct()
        Try
            dbConnection()
            sql = "DELETE FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Products.deleteproductidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while deleting the selected product!")
                Products.deleteproductsearchTB.Focus()
            Else
                MsgBox("Successfully deleted the selected product!")
                Products.deleteproductidLbl.Text = "-"
                Products.deleteproductnameLbl.Text = "-"
                Products.deleteproductsearchTB.Text = ""
                Products.deleteproductsearchTB.Focus()
                Products.deletepicBox.Image = Nothing
                ' refer to retrieveQuery module
                retrieveProductDetailsforView()
                retrieveProductDetailsforUpdate()
                retrieveProductDetailsforDelete()
            End If

        End Try
    End Sub

    ' deletes the customer details
    Public Sub deleteCustomer()
        Try
            dbConnection()
            sql = "DELETE FROM tblcustomer WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Customers.deletecustomeridLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while deleting the selected customer details!")
                Customers.deletecustomersearchTB.Focus()
            Else
                MsgBox("Successfully deleted the selected customer details!")
                Customers.deletecustomeridLbl.Text = "-"
                Customers.deletecustomernameLbl.Text = "-"
                Customers.deletecustomersearchTB.Text = ""
                Customers.deletecustomersearchTB.Focus()
                ' refer to retrieveQuery module
                retrieveCustomerDetailsforView()
                retrieveCustomerDetailsforUpdate()
                retrieveCustomerDetailsforDelete()
            End If

        End Try
    End Sub

    ' deletes the transaction details
    Public Sub deleteTransaction()
        Try
            dbConnection()
            sql = "DELETE FROM tbltransaction WHERE InvoiceID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Transaction.cancelinvoiceidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while deleting the selected transaction!")
                Transaction.canceltransactionsearchTB.Focus()
            Else
                MsgBox("Successfully deleted the selected transaction!")
                deletePayment()
                Transaction.canceltransactionsearchTB.Text = ""
                Transaction.cancelinvoiceidLbl.Text = ""
                Transaction.cancelcontactnoLbl.Text = ""
                Transaction.canceldateLbl.Text = ""
                Transaction.canceladdressLbl.Text = ""
                Transaction.cancelnameLbl.Text = ""
                Transaction.canceltransactionsearchTB.Focus()
                retrieveTransactionDetailsforView()
                retrieveTransactionDetailsforCancel()
            End If

        End Try
    End Sub

    ' deletes the payment details
    Public Sub deletePayment()
        Try
            dbConnection()
            sql = "DELETE FROM tblpayment WHERE InvoiceID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Transaction.cancelinvoiceidLbl.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
