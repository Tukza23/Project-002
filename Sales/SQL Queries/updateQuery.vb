Imports MySql.Data.MySqlClient
Module updateQuery

    Dim arrImage() As Byte
    Dim newnumber As Integer
    Dim newidnumber As String
    Dim updatedidnumber As String
    Public fiveid As String

    ' updates the product details
    Public Sub updateProduct()
        Try
            Dim mstream As New System.IO.MemoryStream()
            Products.updatepicBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            dbConnection()
            sql = "UPDATE tblproduct SET Name = @Name, Discount = @Discount, Price = @Price, InitialPayment = @Payment, Image = @Image WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Products.updateproductnameTB.Text)
                .Parameters.AddWithValue("@Discount", Products.updatediscountTB.Text)
                .Parameters.AddWithValue("@Price", Products.updatepriceTB.Text)
                .Parameters.AddWithValue("@Payment", Products.updatepaymentTB.Text)
                .Parameters.AddWithValue("@Image", arrImage)
                .Parameters.AddWithValue("@ID", Products.updateproductidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while updating the selected product!")
                Products.updateproductsearchTB.Focus()
            Else
                MsgBox("Successfully updated the selected product!")
                Products.updateproductidLbl.Text = "-"
                Products.updateproductnameTB.Text = ""
                Products.updatediscountTB.Text = "0.0"
                Products.updatepriceTB.Text = ""
                Products.updatepaymentTB.Text = ""
                Products.updatepicBox.Image = Nothing
                Products.updateproductsearchTB.Text = ""
                Products.updateproductsearchTB.Focus()
                ' refer to retrieveQuery module
                retrieveProductDetailsforView()
                retrieveProductDetailsforUpdate()
                retrieveProductDetailsforDelete()
            End If

        End Try
    End Sub

    ' updates the customer details
    Public Sub updateCustomer()
        Try
            dbConnection()
            sql = "UPDATE tblcustomer SET Name = @Name, Contact_No = @Contact, Address = @Address WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Customers.updatecustomernameTB.Text)
                .Parameters.AddWithValue("@Contact", Customers.updatecustomercontactTB.Text)
                .Parameters.AddWithValue("@Address", Customers.updatecustomeraddressTB.Text)
                .Parameters.AddWithValue("@ID", Customers.updatecustomeridLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while updating the selected cusstomer details!")
                Customers.updatecustomersearchTB.Focus()
            Else
                MsgBox("Successfully updated the selected customer details!")
                Customers.updatecustomernameTB.Text = ""
                Customers.updatecustomercontactTB.Text = ""
                Customers.updatecustomeraddressTB.Text = ""
                Customers.updatecustomeridLbl.Text = "-"
                Customers.updatecustomersearchTB.Text = ""
                Customers.updatecustomersearchTB.Focus()
                ' refer to retrieveQuery module
                retrieveCustomerDetailsforView()
                retrieveCustomerDetailsforUpdate()
                retrieveCustomerDetailsforDelete()
            End If

        End Try
    End Sub

    ' adds stocks depending on the stock in quantity
    Public Sub updateAddStocks()
        Try
            dbConnection()
            sql = "UPDATE tblproduct SET Stocks = Stocks + @Stocks WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Stocks", Stocks.addstocksTB.Text)
                .Parameters.AddWithValue("@ID", Stocks.addstockidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while adding stock's quantity!")
                Stocks.addstocksTB.Focus()
            Else
                MsgBox("Successfully added stocks!")
                Stocks.addstocksTB.Text = ""
                Stocks.addstockidLbl.Text = "-"
                Stocks.addstocknameTB.Text = ""
                Stocks.addstocksearchTB.Text = ""
                Stocks.addstocksearchTB.Focus()
                Stocks.addpicBox.Image = Nothing
                ' refer to retrieveQuery module
                retrieveStockDetailsforView()
                retrieveStockDetailsforAdd()
                retrieveStockDetailsforDelete()
            End If

        End Try
    End Sub

    ' deducts stocks depending on the stock in quantity
    Public Sub updateDeductStocks()
        Try
            dbConnection()
            sql = "UPDATE tblproduct SET Stocks = Stocks - @Stocks WHERE ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Stocks", Stocks.deletestocksTB.Text)
                .Parameters.AddWithValue("@ID", Stocks.deletestockidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while deducting stock's quantity!")
                Stocks.addstocksTB.Focus()
            Else
                MsgBox("Successfully deducted stocks!")
                Stocks.deletestocksTB.Text = ""
                Stocks.deletestockidLbl.Text = "-"
                Stocks.deletestocknameLbl.Text = ""
                Stocks.deletestocksearchTB.Text = ""
                Stocks.deletestocksearchTB.Focus()
                Stocks.deletepicBox.Image = Nothing
                ' refer to retrieveQuery module
                retrieveStockDetailsforView()
                retrieveStockDetailsforAdd()
                retrieveStockDetailsforDelete()
            End If

        End Try
    End Sub

    ' updates the invoice number if the transaction is successful
    Public Sub updateID()
        newnumber = Integer.Parse(fiveid.ToString) + 1
        newidnumber = newnumber
        If newidnumber.Length = 1 Then
            updatedidnumber = "0000" + newidnumber
        ElseIf newidnumber.Length = 2 Then
            updatedidnumber = "000" + newidnumber
        ElseIf newidnumber.Length = 3 Then
            updatedidnumber = "00" + newidnumber
        ElseIf newidnumber.Length = 4 Then
            updatedidnumber = "0" + newidnumber
        Else
            updatedidnumber = newidnumber
        End If
        Try
            dbConnection()
            sql = "UPDATE tblid SET ID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", updatedidnumber)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            newidnumber = ""
            updatedidnumber = ""
            newnumber = 0
            ' refer to retrieveQuery module
            retrieveIDforAddingTransaction()
        End Try
    End Sub

    ' updates the OR number if the transaction is successful
    Public Sub updateORID()
        newnumber = Integer.Parse(orid.ToString) + 1
        newidnumber = newnumber
        If newidnumber.Length = 1 Then
            updatedidnumber = "0000" + newidnumber
        ElseIf newidnumber.Length = 2 Then
            updatedidnumber = "000" + newidnumber
        ElseIf newidnumber.Length = 3 Then
            updatedidnumber = "00" + newidnumber
        ElseIf newidnumber.Length = 4 Then
            updatedidnumber = "0" + newidnumber
        Else
            updatedidnumber = newidnumber
        End If
        Try
            dbConnection()
            sql = "UPDATE tblid SET ID2 = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", updatedidnumber)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            newidnumber = ""
            updatedidnumber = ""
            newnumber = 0
        End Try
    End Sub

    ' updates the stocks quantity depending on the selected product for purchase
    Public Sub updatePurchasedStock()
        Try
            dbConnection()
            sql = "UPDATE tblproduct SET Stocks = Stocks - @Stocks WHERE Name = @Name;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Stocks", 1)
                .Parameters.AddWithValue("@Name", Transaction.addproductnameTB.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    ' updates the payment trail depending on the min date
    Public Sub updatePaymentTrailDetails()
        Try
            dbConnection()
            sql = "UPDATE tblpaymenttrail SET ORID = @ORID, Amount = @Amount WHERE Date = @Date AND InvoiceID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ORID", Payments.updateornoLbl.Text)
                .Parameters.AddWithValue("@Amount", Payments.updatetobepaidTB.Text)
                .Parameters.AddWithValue("@Date", Date.Parse(Payments.updatecurrentduedateLbl.Text).ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@ID", Payments.updateinvoiceidLbl.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while making payment details!")
                Payments.updatepaymentsearchTB.Focus()
            Else
                MsgBox("Successfully created new payment details!")
                ' refer to updateQuery module
                updatePaymentDetails()
            End If
        End Try
    End Sub

    ' updates total price if due date was not met
    Public Sub updateTotalPricePayment()
        Try
            dbConnection()
            sql = "UPDATE tblpayment SET TotalFee = TotalFee + 300 WHERE InvoiceID = @ID;"
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Payments.updateinvoiceidLbl.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            Payments.updatesurchargeLbl.Text = "300.00"
            ' refer to retrieveQuery module
            retrieveTotalFee()
        End Try
    End Sub

    ' updates the payment details of customer's accumulated payment and pending balance
    Public Sub updatePaymentDetails()
        Try
            dbConnection()
            sql = "UPDATE tblpayment SET Balance = Balance - @Balance, AccumulatedPayment = AccumulatedPayment + @Payment WHERE InvoiceID = @ID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Balance", Payments.updatetobepaidTB.Text)
                .Parameters.AddWithValue("@Payment", Payments.updatetobepaidTB.Text)
                .Parameters.AddWithValue("@ID", Payments.updateinvoiceidLbl.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dt = New DataTable
            With dt
                .Columns.Add("Invoice ID")
                .Columns.Add("OR ID")
                .Columns.Add("Date")
                .Columns.Add("Name")
                .Columns.Add("Due Date")
                .Columns.Add("Amount Paid")
                .Columns.Add("Total Price")
                .Columns.Add("Total Payment")
                .Columns.Add("Balance")
                .Columns.Add("Surcharge")
            End With
            dt.Rows.Add(Payments.updateinvoiceidLbl.Text, Payments.updateornoLbl.Text, Date.Now.ToString("yyyy-MM-dd"), Payments.updatenameLbl.Text, Payments.updatecurrentduedateLbl.Text, _
                        Payments.updatetobepaidTB.Text, Payments.updatetotalunitpriceLbl.Text, Decimal.Parse(Payments.updateaccumulatedpaymentLbl.Text) + Decimal.Parse(Payments.updatetobepaidTB.Text), _
                        Decimal.Parse(Payments.updatebalanceLbl.Text) - Decimal.Parse(Payments.updatetobepaidTB.Text), Payments.updatesurchargeLbl.Text)
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New paymentReceipt
            rptDoc.SetDataSource(dt)
            ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            ReportViewer.ShowDialog()
            ReportViewer.Dispose()
            Payments.updatepaymentsearchTB.Text = ""
            Payments.ListView2.Items.Clear()
            Payments.updateinvoiceidLbl.Text = ""
            Payments.updatenameLbl.Text = ""
            Payments.updateduedateLbl.Text = ""
            Payments.updatestatusLbl.Text = ""
            Payments.updatetotalunitpriceLbl.Text = ""
            Payments.updatemonthlypayment.Text = ""
            Payments.updateaccumulatedpaymentLbl.Text = ""
            Payments.updatebalanceLbl.Text = ""
            Payments.updateornoLbl.Text = ""
            Payments.updatecurrentduedateLbl.Text = ""
            Payments.updatesurchargeLbl.Text = "0.00"
            Payments.updatetobepaidTB.Text = ""
            Payments.updateconfirmBtn.Enabled = True
            ' refer to retrieveQuery module
            retrievePaymentDetailsforView()
            ' refer to updateQuery module
            updateORID()
        End Try
    End Sub
End Module
