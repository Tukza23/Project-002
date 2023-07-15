Imports MySql.Data.MySqlClient

Module searchQuery

    ' for searching of data in view product
    Public Sub searchViewProductDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Products.viewproductsearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Products.ListView1.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(2))
                p.SubItems.Add(dr(3))
                p.SubItems.Add(dr(4))
                p.SubItems.Add(dr(5))
                Products.ListView1.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in update product
    Public Sub searchUpdateProductDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Products.updateproductsearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Products.ListView2.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(2))
                p.SubItems.Add(dr(3))
                p.SubItems.Add(dr(4))
                p.SubItems.Add(dr(5))
                Products.ListView2.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in delete product
    Public Sub searchDeleteProductDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Products.deleteproductsearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Products.ListView3.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                Products.ListView3.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in view customer
    Public Sub searchViewCustomerDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer WHERE Name LIKE '%" & Customers.viewcustomersearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Customers.ListView1.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(2))
                p.SubItems.Add(dr(3))
                Customers.ListView1.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in update customer
    Public Sub searchUpdateCustomerDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer WHERE Name LIKE '%" & Customers.updatecustomersearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Customers.ListView2.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(2))
                p.SubItems.Add(dr(3))
                Customers.ListView2.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in delete customer
    Public Sub searchDeleteCustomerDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer WHERE Name LIKE '%" & Customers.deletecustomersearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Customers.ListView3.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                Customers.ListView3.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in view stock
    Public Sub searchViewStockDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Stocks.viewstockssearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Stocks.ListView1.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(5))
                Stocks.ListView1.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in add stock
    Public Sub searchAddStockDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Stocks.addstocksearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Stocks.ListView2.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(5))
                Stocks.ListView2.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in delete stock
    Public Sub searchDeleteStockDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name LIKE '%" & Stocks.deletestocksearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Stocks.ListView3.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(5))
                Stocks.ListView3.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in view transaction
    Public Sub searchViewTransactionDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tbltransaction WHERE InvoiceID LIKE '%" & Transaction.viewtransactionsearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Transaction.ListView1.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(2))
                Transaction.ListView1.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in cancel transaction
    Public Sub searchCancelTransactionDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tbltransaction WHERE InvoiceID LIKE '%" & Transaction.canceltransactionsearchTB.Text & "%';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Transaction.ListView2.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(2))
                Transaction.ListView2.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' for searching of data in view payments
    Public Sub searchViewPaymentDetails()
        Try
            dbConnection()
            sql = "SELECT tblpayment.InvoiceID, tbltransaction.Name, tblpayment.TotalPrice, tblpayment.Downpayment, tblpayment.Interest, tblpayment.Monthly, " & _
                  "tblpayment.TotalFee, tblpayment.Balance, tblpayment.DueDate, tblpayment.AccumulatedPayment FROM tblpayment, tbltransaction WHERE " & _
                  "tblpayment.InvoiceID = '" & Payments.viewpaymentsearchTB.Text & "' AND tbltransaction.InvoiceID = '" & Payments.viewpaymentsearchTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Payments.ListView1.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(1))
                p.SubItems.Add(dr(2))
                p.SubItems.Add(dr(3))
                p.SubItems.Add(dr(4))
                p.SubItems.Add(dr(5))
                p.SubItems.Add(dr(6))
                p.SubItems.Add(dr(7))
                p.SubItems.Add(dr(8))
                p.SubItems.Add(dr(9))
                Payments.ListView1.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            If Payments.ListView1.Items.Count > 0 Then
                MsgBox("Showing results!")
            Else
                MsgBox("No results!")
            End If
            Payments.viewinvoiceidLbl.Text = ""
            Payments.viewcustomernameLbl.Text = ""
            Payments.viewtotalpriceLbl.Text = ""
            Payments.viewdownpaymentLbl.Text = ""
            Payments.viewmonthlyLbl.Text = ""
            Payments.viewtotalpriceinterestLbl.Text = ""
            Payments.viewbalanceLbl.Text = ""
            Payments.viewduedateLbl.Text = ""
            Payments.viewtotalaccumulatedpaymentLbl.Text = ""
            Payments.viewstatusLbl.Text = ""
        End Try
    End Sub

    ' for searching of data in update payments
    Public Sub searchUpdatePaymentDetails()
        Try
            dbConnection()
            sql = "SELECT ORID, Date, Amount, InvoiceID FROM tblpaymenttrail WHERE InvoiceID = '" & Payments.updatepaymentsearchTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Dim p As ListViewItem
            Payments.ListView2.Items.Clear()
            Do While dr.Read = True
                p = New ListViewItem(dr(0).ToString)
                p.SubItems.Add(dr(3))
                p.SubItems.Add(Date.Parse(dr(1)).ToString("yyyy-MM-dd"))
                p.SubItems.Add(dr(2))
                Payments.ListView2.Items.Add(p)
            Loop
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            If Payments.ListView2.Items.Count > 0 Then
                MsgBox("Showing results!")
                conn.Close()
                dr.Close()
                ' refer to retrieveQuery module
                retrieveCustomerPaymentDetails()
            Else
                MsgBox("No results!")
                conn.Close()
                dr.Close()
            End If
        End Try
    End Sub

End Module
