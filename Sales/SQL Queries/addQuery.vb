Imports MySql.Data.MySqlClient
Module addQuery

    Dim arrImage() As Byte
    Dim duedate As Date
    Dim dateinteger As Integer = 0
    Dim incrementaldate As Integer = 0
    Dim declareddate As Date
    Public orid As String
    Public oridstring As String

    ' adding new product details
    Public Sub addProduct()
        Try
            Dim mstream As New System.IO.MemoryStream()
            Products.addpicBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            dbConnection()
            sql = "INSERT INTO tblproduct (`Name`,`Discount`,`Price`,`InitialPayment`,`Stocks`,`Image`) VALUES (@Name, @Discount, @Price, @Payment, @Stocks, @Image);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Products.addnameTB.Text)
                .Parameters.AddWithValue("@Discount", Products.adddiscountTB.Text)
                .Parameters.AddWithValue("@Price", Products.addpriceTB.Text)
                .Parameters.AddWithValue("@Payment", Products.addpaymentTB.Text)
                .Parameters.AddWithValue("@Stocks", 0)
                .Parameters.AddWithValue("Image", arrImage)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while adding new product!")
                Products.addnameTB.Focus()
            Else
                MsgBox("Successfully added new product details!")
                Products.addnameTB.Text = ""
                Products.adddiscountTB.Text = "0.0"
                Products.addpriceTB.Text = ""
                Products.addpaymentTB.Text = ""
                Products.addpicBox.Image = Nothing
                Products.addnameTB.Focus()
                ' refer to retrieveQuery module
                retrieveProductDetailsforView()
                retrieveProductDetailsforUpdate()
                retrieveProductDetailsforDelete()
            End If

        End Try
    End Sub

    ' adding new customer details
    Public Sub addCustomer()
        Try
            dbConnection()
            sql = "INSERT INTO tblcustomer (`Name`,`Contact_No`,`Address`) VALUES (@Name, @Contact, @Address);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", Customers.addnameTB.Text)
                .Parameters.AddWithValue("@Contact", Customers.addcontactTB.Text)
                .Parameters.AddWithValue("@Address", Customers.addaddressTB.Text)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while adding new customer details!")
                Customers.addnameTB.Focus()
            Else
                MsgBox("Successfully added new customer details!")
                Customers.addnameTB.Text = ""
                Customers.addcontactTB.Text = ""
                Customers.addaddressTB.Text = ""
                Customers.addnameTB.Focus()
                ' refer to retrieveQuery module
                retrieveCustomerDetailsforView()
                retrieveCustomerDetailsforUpdate()
                retrieveCustomerDetailsforDelete()
            End If

        End Try
    End Sub

    ' adding new transaction details
    Public Sub addTransaction()
        Try
            dbConnection()
            sql = "INSERT INTO tbltransaction (`InvoiceID`,`Date`,`Name`,`Contact`,`Address`,`Product`,`Engine`,`Color`,`Model`,`Rate`,`Terms`) VALUES " & _
                  "(@ID, @Date, @Name, @Contact, @Address, @Product, @Engine, @Color, @Model, @Rate, @Terms);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Transaction.addinvoiceidLbl.Text)
                .Parameters.AddWithValue("@Date", Transaction.adddateLbl.Text)
                .Parameters.AddWithValue("@Name", Transaction.addnameTB.Text)
                .Parameters.AddWithValue("@Contact", Transaction.addcontactTB.Text)
                .Parameters.AddWithValue("@Address", Transaction.addaddressTB.Text)
                .Parameters.AddWithValue("@Product", Transaction.addproductnameTB.Text)
                .Parameters.AddWithValue("@Engine", Transaction.addengineTB.Text)
                .Parameters.AddWithValue("@Color", Transaction.addcolorTB.Text)
                .Parameters.AddWithValue("@Model", Transaction.addmodelCB.SelectedItem)
                .Parameters.AddWithValue("@Rate", Transaction.addrateTB.Text)
                .Parameters.AddWithValue("@Terms", Transaction.addtermsCB.SelectedItem)
                result = .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            result = 0
        Finally
            If result = 0 Then
                MsgBox("Error occurred while adding new transaction!")
                Transaction.addnameTB.Focus()
            Else
                MsgBox("Successfully added new transaction!")
                addNewPaymentDetails()
            End If
        End Try
    End Sub

    ' adding new payment details from adding transaction
    Public Sub addNewPaymentDetails()
        If Transaction.addtermsCB.SelectedItem = "12" Then
            duedate = Date.Now.AddYears(1).ToString("yyyy-MM-dd")
            dateinteger = 12
        ElseIf Transaction.addtermsCB.SelectedItem = "24" Then
            duedate = Date.Now.AddYears(2).ToString("yyyy-MM-dd")
            dateinteger = 24
        ElseIf Transaction.addtermsCB.SelectedItem = "36" Then
            duedate = Date.Now.AddYears(3).ToString("yyyy-MM-dd")
            dateinteger = 36
        Else
            duedate = ""
            dateinteger = 0
        End If
        Try
            dbConnection()
            sql = "INSERT INTO tblpayment (`InvoiceID`,`TotalPrice`,`Downpayment`,`Interest`,`Monthly`,`TotalFee`,`Balance`,`DueDate`,`AccumulatedPayment`) VALUES " & _
                  "(@ID, @Price, @Downpayment, @Interest, @Monthly, @Total, @Balance, @DueDate, @Payment);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", Transaction.addinvoiceidLbl.Text)
                .Parameters.AddWithValue("@Price", Transaction.addtotalpriceLbl.Text)
                .Parameters.AddWithValue("@Downpayment", Transaction.adddownpaymentLbl.Text)
                .Parameters.AddWithValue("@Interest", Transaction.addinterestrateLbl.Text)
                .Parameters.AddWithValue("@Monthly", Transaction.addmonthlyfeeLbl.Text)
                .Parameters.AddWithValue("@Total", Transaction.addtotalfeeLbl.Text)
                .Parameters.AddWithValue("@Balance", Transaction.addbalanceLbl.Text)
                .Parameters.AddWithValue("@DueDate", duedate.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@Payment", Transaction.adddownpaymentLbl.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            ' refer to addQuery module
            addFirstPaymentTrack()
            addPaymentTrailDependingOnTerms()
            ' refer to updateQuery module
            updatePurchasedStock()
            dt = New DataTable
            With dt
                .Columns.Add("Invoice ID")
                .Columns.Add("Date")
                .Columns.Add("Name")
                .Columns.Add("Contact")
                .Columns.Add("Address")
                .Columns.Add("Product")
                .Columns.Add("Engine")
                .Columns.Add("Color")
                .Columns.Add("Model")
                .Columns.Add("Terms")
                .Columns.Add("TotalPrice")
                .Columns.Add("Downpayment")
                .Columns.Add("Interest")
                .Columns.Add("Monthly")
                .Columns.Add("TotalFee")
                .Columns.Add("Balance")
                .Columns.Add("Due Date")
                .Columns.Add("ORID")
            End With
            dt.Rows.Add(Transaction.addinvoiceidLbl.Text, Transaction.adddateLbl.Text, Transaction.addnameTB.Text, Transaction.addcontactTB.Text, Transaction.addaddressTB.Text, _
                        Transaction.addproductnameTB.Text, Transaction.addengineTB.Text, Transaction.addcolorTB.Text, Transaction.addmodelCB.SelectedItem, Transaction.addtermsCB.SelectedItem, _
                        Transaction.addtotalpriceLbl.Text, Transaction.adddownpaymentLbl.Text, Transaction.addinterestrateLbl.Text, Transaction.addmonthlyfeeLbl.Text, _
                        Transaction.addtotalfeeLbl.Text, Transaction.addbalanceLbl.Text, duedate.ToString("yyyy-MM-dd"), oridstring.ToString)
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New transactionReceipt
            rptDoc.SetDataSource(dt)
            ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            ReportViewer.ShowDialog()
            ReportViewer.Dispose()
            Transaction.addnameTB.Text = ""
            Transaction.addcontactTB.Text = ""
            Transaction.addaddressTB.Text = ""
            Transaction.addproductnameTB.Text = ""
            Transaction.addengineTB.Text = ""
            Transaction.addcolorTB.Text = ""
            Transaction.addmodelCB.SelectedItem = ""
            Transaction.addrateTB.Text = ""
            Transaction.addtermsCB.SelectedItem = ""
            Transaction.addpicBox.Image = Nothing
            Transaction.addtotalpriceLbl.Text = "0.00"
            Transaction.adddownpaymentLbl.Text = "0.00"
            Transaction.addinterestrateLbl.Text = "0.00"
            Transaction.addmonthlyfeeLbl.Text = "0.00"
            Transaction.addtotalpriceLbl.Text = "0.00"
            Transaction.addbalanceLbl.Text = "0.00"
            ' refer to updateQuery module
            updateID()
            ' refer to retrieveQuery module
            retrieveTransactionDetailsforView()
            retrieveTransactionDetailsforCancel()
        End Try
    End Sub

    ' adds blank amount trail based on monthly payment
    Public Sub addPaymentTrailDependingOnTerms()
        incrementaldate = 1
        For i As Integer = 1 To dateinteger
            declareddate = Date.Now.AddMonths(incrementaldate).ToString("yyyy-MM-dd")
            Try
                dbConnection()
                sql = "INSERT INTO tblpaymenttrail (`Date`,`Amount`,`InvoiceID`) VALUES (@Date, @Amount, @ID);"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Date", declareddate)
                    .Parameters.AddWithValue("Amount", 0)
                    .Parameters.AddWithValue("@ID", Transaction.addinvoiceidLbl.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
            incrementaldate += 1
        Next
    End Sub

    ' adds first payment trail based on the made transaction
    Public Sub addFirstPaymentTrack()
        ' refer to retrieveQuery module
        retrieveORIDforAddingTransaction()
        Try
            dbConnection()
            sql = "INSERT INTO tblpaymenttrail (`ORID`,`Date`,`Amount`,`InvoiceID`) VALUES (@ORID, @Date, @Amount, @ID);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.AddWithValue("@ORID", oridstring.ToString)
                .Parameters.AddWithValue("@Date", Transaction.adddateLbl.Text)
                .Parameters.AddWithValue("@Amount", Transaction.adddownpaymentLbl.Text)
                .Parameters.AddWithValue("@ID", Transaction.addinvoiceidLbl.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            ' refer to updateQuery module
            updateORID()
        End Try
    End Sub

End Module
