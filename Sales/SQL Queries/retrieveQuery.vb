Imports MySql.Data.MySqlClient
Module retrieveQuery

    Dim arrImage() As Byte

    ' retrieves product details from database to view product listview
    Public Sub retrieveProductDetailsforView()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves product details from database to update product listview
    Public Sub retrieveProductDetailsforUpdate()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves product details from database to delete product listview
    Public Sub retrieveProductDetailsforDelete()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves transaction details from database to view transaction listview
    Public Sub retrieveTransactionDetailsforView()
        Try
            dbConnection()
            sql = "SELECT * from tbltransaction;"
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

    ' retrieves transaction details from database to cancel transaction listview
    Public Sub retrieveTransactionDetailsforCancel()
        Try
            dbConnection()
            sql = "SELECT * from tbltransaction;"
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

    ' retrieves payment details from database to view payment listview
    Public Sub retrievePaymentDetailsforView()
        Try
            dbConnection()
            sql = "SELECT tblpayment.InvoiceID, tbltransaction.Name, tblpayment.TotalPrice, tblpayment.Downpayment, tblpayment.Interest, tblpayment.Monthly, " & _
                  "tblpayment.TotalFee, tblpayment.Balance, tblpayment.DueDate, tblpayment.AccumulatedPayment FROM tblpayment, tbltransaction WHERE " & _
                  "tblpayment.InvoiceID = tbltransaction.InvoiceID;"
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
        End Try
    End Sub

    ' retrieves the supporting image for view products
    Public Sub retrieveImageforViewProducts()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Products.productidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Products.viewpicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the supporting image for update products
    Public Sub retrieveImageforUpdateProducts()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Products.updateproductidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Products.updatepicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the supporting image for delete products
    Public Sub retrieveImageforDeleteProducts()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Products.deleteproductidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Products.deletepicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves customer details from database to view customer listview
    Public Sub retrieveCustomerDetailsforView()
        Try
            dbConnection()
            sql = "SELECT * from tblcustomer;"
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

    ' retrieves customer details from database to update customer listview
    Public Sub retrieveCustomerDetailsforUpdate()
        Try
            dbConnection()
            sql = "SELECT * from tblcustomer;"
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

    ' retrieves customer details from database to delete customer listview
    Public Sub retrieveCustomerDetailsforDelete()
        Try
            dbConnection()
            sql = "SELECT * from tblcustomer;"
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

    ' retrieves product details from database to view stock listview
    Public Sub retrieveStockDetailsforView()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves product details from database to add stock listview
    Public Sub retrieveStockDetailsforAdd()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves product details from database to delete stock listview
    Public Sub retrieveStockDetailsforDelete()
        Try
            dbConnection()
            sql = "SELECT * from tblproduct;"
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

    ' retrieves the supporting image for view stocks
    Public Sub retrieveImageforViewStocks()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Stocks.stockidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Stocks.viewpicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the supporting image for add stocks
    Public Sub retrieveImageforAddStocks()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Stocks.addstockidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Stocks.addpicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the supporting image for delete stocks
    Public Sub retrieveImageforDeleteStocks()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Stocks.deletestockidLbl.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Stocks.deletepicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the customer name for add transaction module
    Public Sub retrieveCustomerNameforAddTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Transaction.addnameTB.AutoCompleteCustomSource.Add(dr(1))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' retrieves the product name for add transaction module
    Public Sub retrieveProductNameforAddTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Transaction.addproductnameTB.AutoCompleteCustomSource.Add(dr(1))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' retrieves the customer details for add transaction module
    Public Sub retrieveCustomerDetailsforAddTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer WHERE Name = @Name;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Transaction.addnameTB.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Transaction.addcontactTB.Text = dt.Rows(0).Item(2)
                Transaction.addaddressTB.Text = dt.Rows(0).Item(3)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the product details for add transaction module
    Public Sub retrieveProductDetailsforAddTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name = @Name;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Transaction.addproductnameTB.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Transaction.addtotalpriceLbl.Text = dt.Rows(0).Item(3)
                Transaction.adddownpaymentLbl.Text = dt.Rows(0).Item(4)
                arrImage = dt.Rows(0).Item(6)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Transaction.addpicBox.Image = Image.FromStream(mstream)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    ' retrieves the stored ID to be used as invoice number
    Public Sub retrieveIDforAddingTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblid;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                fiveid = dr.GetString("ID")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            Transaction.addinvoiceidLbl.Text = "A-" & fiveid
        End Try
    End Sub

    ' retrieves quantity if 0 or not
    Public Sub retrieveSelectedProductsQuantity()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct WHERE Name = @Name;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Transaction.addproductnameTB.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            conn.Close()
            da.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            If dt.Rows.Count > 0 Then
                checkQuantity = dt.Rows(0).Item(5)
            Else
                checkQuantity = 0
            End If
        End Try
    End Sub

    ' retrieves transaction details for the rest view transaction details
    Public Sub retrieveRestofTransactionDetails()
        Try
            dbConnection()
            sql = "SELECT * FROM tbltransaction WHERE InvoiceID = '" & Transaction.viewinvoiceidLbl.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Transaction.viewdateLbl.Text = dr.GetDateTime(1).ToString("yyyy-MM-dd")
                Transaction.viewcontactLbl.Text = dr.GetString(3)
                Transaction.viewaddressLbl.Text = dr.GetString(4)
                Transaction.viewproductnameLbl.Text = dr.GetString(5)
                Transaction.viewengineLbl.Text = dr.GetString(6)
                Transaction.viewcolorLbl.Text = dr.GetString(7)
                Transaction.viewmodelLbl.Text = dr.GetString(8)
                Transaction.viewrateLbl.Text = dr.GetString(9)
                Transaction.viewtermsLbl.Text = dr.GetString(10)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' retrieves transaction details for the rest cancel transaction details
    Public Sub retrieveRestofTransactionDetails2()
        Try
            dbConnection()
            sql = "SELECT * FROM tbltransaction WHERE InvoiceID = '" & Transaction.cancelinvoiceidLbl.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Transaction.canceldateLbl.Text = dr.GetDateTime(1).ToString("yyyy-MM-dd")
                Transaction.cancelcontactnoLbl.Text = dr.GetString(3)
                Transaction.canceladdressLbl.Text = dr.GetString(4)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    ' retrieves the stored ID to be used as OR number in adding transaction
    Public Sub retrieveORIDforAddingTransaction()
        Try
            dbConnection()
            sql = "SELECT * FROM tblid;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                orid = dr.GetString("ID2")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            oridstring = "O-" & orid.ToString
        End Try
    End Sub

    ' retrieves the stored ID to be used as OR number in updating payment details 
    Public Sub retrieveORIDforUpdatingPayments()
        Try
            dbConnection()
            sql = "SELECT * FROM tblid;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                orid = dr.GetString("ID2")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            Payments.updateornoLbl.Text = "O-" & orid.ToString
            If Date.Parse(Payments.updatecurrentduedateLbl.Text).ToString("yyyy-MM-dd") < Date.Now.ToString("yyyy-MM-dd") Then
                ' refer to updateQuery module
                updateTotalPricePayment()
            Else
                Payments.updatetobepaidTB.Focus()
            End If
        End Try
    End Sub

    ' retrieves customer's details for update payment
    Public Sub retrieveCustomerPaymentDetails()
        Try
            dbConnection()
            sql = "SELECT tbltransaction.InvoiceID, tbltransaction.Name, tblpayment.DueDate, tblpayment.Monthly, tblpayment.Balance, tblpayment.AccumulatedPayment, tblpayment.TotalFee FROM tbltransaction, tblpayment WHERE tbltransaction.InvoiceID = '" & Payments.updatepaymentsearchTB.Text & "' AND tblpayment.InvoiceID = '" & Payments.updatepaymentsearchTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Payments.updateinvoiceidLbl.Text = dr.GetString(0)
                Payments.updatenameLbl.Text = dr.GetString(1)
                Payments.updateduedateLbl.Text = Date.Parse(dr.GetString(2)).ToString("yyyy-MM-dd")
                Payments.updatemonthlypayment.Text = dr.GetString(3)
                Payments.updatebalanceLbl.Text = dr.GetString(4)
                Payments.updateaccumulatedpaymentLbl.Text = dr.GetString(5)
                Payments.updatetotalunitpriceLbl.Text = dr.GetString(6)
                Payments.updatetobepaidTB.Text = dr.GetString(3)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            If Payments.updatebalanceLbl.Text <> 0 Then
                Payments.updatestatusLbl.Text = "ON-PAYMENT PROCESS"
                Payments.updatestatusLbl.ForeColor = Color.Maroon
                Payments.updateconfirmBtn.Enabled = True
                ' refer to retrieveQuery module
                retrieveMinimumDatePayment()
            ElseIf Payments.updatebalanceLbl.Text <= 0 Then
                Payments.updatestatusLbl.Text = "COMPLETED"
                Payments.updatestatusLbl.ForeColor = Color.DarkGreen
                Payments.updateconfirmBtn.Enabled = False
            End If
        End Try
    End Sub

    ' retrieves the next month to be paid by customer
    Public Sub retrieveMinimumDatePayment()
        Try
            dbConnection()
            sql = "SELECT MIN(Date) FROM tblpaymenttrail WHERE Amount = 0.0 AND InvoiceID = '" & Payments.updatepaymentsearchTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Payments.updatecurrentduedateLbl.Text = Date.Parse(dr.GetString(0)).ToString("yyyy-MM-dd")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            ' refer to retrieveQuery module
            retrieveORIDforUpdatingPayments()
        End Try
    End Sub

    ' retrieves total price from addedsurcharge
    Public Sub retrieveTotalFee()
        Try
            dbConnection()
            sql = "SELECT TotalFee FROM tblpayment WHERE InvoiceID = '" & Payments.updateinvoiceidLbl.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Payments.updatetotalunitpriceLbl.Text = dr.GetString(0)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

End Module
