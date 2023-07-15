Imports MySql.Data.MySqlClient
Module reportQuery

    ' prints the summary report of customers
    Public Sub printCustomerReport()
        Try
            dbConnection()
            sql = "SELECT * FROM tblcustomer;"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            With dt
                .Columns.Add("ID")
                .Columns.Add("Name")
                .Columns.Add("Contact_No")
                .Columns.Add("Address")
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New customerReport
            rptDoc.SetDataSource(dt)
            ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            ReportViewer.ShowDialog()
            ReportViewer.Dispose()
        End Try
    End Sub

    ' prints the summary report of products
    Public Sub printProductReport()
        Try
            dbConnection()
            sql = "SELECT * FROM tblproduct;"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            With dt
                .Columns.Add("ID")
                .Columns.Add("Name")
                .Columns.Add("Price")
                .Columns.Add("InitialPayment")
                .Columns.Add("Stocks")
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New productsReport
            rptDoc.SetDataSource(dt)
            ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            ReportViewer.ShowDialog()
            ReportViewer.Dispose()
        End Try
    End Sub

    ' prints the summary report of payments
    Public Sub printPaymentsReport()
        Try
            dbConnection()
            sql = "SELECT InvoiceID, TotalFee, Downpayment, Balance, DueDate, AccumulatedPayment, Monthly FROM tblpayment;"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ReportSelection.DataGridView1.DataSource = dt
            dt2 = New DataTable
            With dt2
                .Columns.Add("InvoiceID")
                .Columns.Add("TotalFee")
                .Columns.Add("Downpayment")
                .Columns.Add("Balance")
                .Columns.Add("DueDate")
                .Columns.Add("AccumulatedPayment")
                .Columns.Add("Monthly")
            End With
            For Each dr As DataGridViewRow In ReportSelection.DataGridView1.Rows
                Dim duedate As Date
                duedate = dr.Cells(4).Value
                dt2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, _
                           duedate.ToString("yyyy-MM-dd"), dr.Cells(5).Value, dr.Cells(6).Value)
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New paymentsReport
            rptDoc.SetDataSource(dt2)
            ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            ReportViewer.ShowDialog()
            ReportViewer.Dispose()
        End Try
    End Sub

    ' prints the individual's payment trail
    Public Sub printPaymentsTrailReport()
        Try
            dbConnection()
            sql = "SELECT tblpaymenttrail.ORID, tblpaymenttrail.Date, tblpaymenttrail.Amount, tblpayment.InvoiceID, tblpayment.TotalFee, tblpayment.AccumulatedPayment, " & _
                  "tblpayment.Balance, tblpayment.DueDate, tbltransaction.Name, tbltransaction.Product, tbltransaction.Contact, tbltransaction.Address FROM tblpaymenttrail, tblpayment, " & _
                  "tbltransaction WHERE tblpaymenttrail.InvoiceID = '" & PaymentTrailSearch.invoiceidTB.Text & "' AND tblpayment.InvoiceID = '" & PaymentTrailSearch.invoiceidTB.Text & "' AND " & _
                  "tbltransaction.InvoiceID = '" & PaymentTrailSearch.invoiceidTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            PaymentTrailSearch.DataGridView1.DataSource = dt
            dt2 = New DataTable
            With dt2
                .Columns.Add("ORID")
                .Columns.Add("Date")
                .Columns.Add("Amount")
                .Columns.Add("InvoiceID")
                .Columns.Add("TotalFee")
                .Columns.Add("AccumulatedPayment")
                .Columns.Add("Balance")
                .Columns.Add("DueDate")
                .Columns.Add("Name")
                .Columns.Add("Product")
                .Columns.Add("Contact")
                .Columns.Add("Address")
                .Columns.Add("Status")
            End With
            For Each dr As DataGridViewRow In PaymentTrailSearch.DataGridView1.Rows
                Dim duedate As Date
                Dim ddate As Date
                Dim status As String
                If dr.Cells(6).Value = 0.0 Then
                    status = "COMPLETED"
                Else
                    status = "ON-PROCESS"
                End If
                ddate = dr.Cells(1).Value
                duedate = dr.Cells(7).Value
                dt2.Rows.Add(dr.Cells(0).Value, ddate.ToString("yyyy-MM-dd"), dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, _
                             duedate.ToString("yyyy-MM-dd"), dr.Cells(8).Value, dr.Cells(9).Value, dr.Cells(10).Value, dr.Cells(11).Value, status.ToString)
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            If dt.Rows.Count > 0 Then
                MsgBox("Generating Report Preview!")
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New paymenttrailReport
                rptDoc.SetDataSource(dt2)
                ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
                ReportViewer.ShowDialog()
                ReportViewer.Dispose()
                PaymentTrailSearch.invoiceidTB.Text = ""
                PaymentTrailSearch.invoiceidTB.Focus()
            Else
                MsgBox("No results!")
                PaymentTrailSearch.invoiceidTB.Focus()
            End If
        End Try
    End Sub

    ' prints the individual's transaction trail
    Public Sub printIndividualTransactionReport()
        Try
            dbConnection()
            sql = "SELECT * FROM tbltransaction WHERE InvoiceID = '" & TransactionSearch.invoiceidTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            TransactionSearch.DataGridView1.DataSource = dt
            dt2 = New DataTable
            With dt2
                .Columns.Add("InvoiceID")
                .Columns.Add("Date")
                .Columns.Add("Name")
                .Columns.Add("Contact")
                .Columns.Add("Address")
                .Columns.Add("Product")
                .Columns.Add("Engine")
                .Columns.Add("Color")
                .Columns.Add("Model")
                .Columns.Add("Rate")
                .Columns.Add("Terms")
            End With
            For Each dr As DataGridViewRow In TransactionSearch.DataGridView1.Rows
                Dim ddate As Date
                ddate = dr.Cells(1).Value
                dt2.Rows.Add(dr.Cells(0).Value, ddate.ToString("yyyy-MM-dd"), dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, _
                             dr.Cells(7).Value, dr.Cells(8).Value, dr.Cells(9).Value, dr.Cells(10).Value & " months")
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            If dt.Rows.Count > 0 Then
                MsgBox("Generating Report Preview!")
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New individualtransactionReport
                rptDoc.SetDataSource(dt2)
                ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
                ReportViewer.ShowDialog()
                ReportViewer.Dispose()
                TransactionSearch.invoiceidTB.Text = ""
                TransactionSearch.invoiceidTB.Focus()
            Else
                MsgBox("No results!")
                TransactionSearch.invoiceidTB.Focus()
            End If
        End Try
    End Sub

    ' prints the summary transaction trail
    Public Sub printSummaryTransactionReport()
        Try
            dbConnection()
            sql = "SELECT tbltransaction.InvoiceID, tbltransaction.Date, tbltransaction.Name, tbltransaction.Address, tbltransaction.Engine, tbltransaction.Color, tbltransaction.Model, " & _
                  "tbltransaction.Rate, tbltransaction.Terms, tblpayment.TotalFee, tblpayment.Downpayment, tblpayment.AccumulatedPayment FROM tbltransaction, tblpayment " & _
                  "WHERE tbltransaction.Date BETWEEN '" & TransactionSummarySearch.dateFrom.Value.ToString("yyyy-MM-dd") & "' AND '" & TransactionSummarySearch.dateTo.Value.ToString("yyyy-MM-dd") & "' AND " & _
                  "tbltransaction.InvoiceID = tblpayment.InvoiceID;"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            TransactionSummarySearch.DataGridView1.DataSource = dt
            dt2 = New DataTable
            With dt2
                .Columns.Add("InvoiceID")
                .Columns.Add("Date")
                .Columns.Add("Name")
                .Columns.Add("Address")
                .Columns.Add("Engine")
                .Columns.Add("Color")
                .Columns.Add("Model")
                .Columns.Add("Rate")
                .Columns.Add("Terms")
                .Columns.Add("TotalFee")
                .Columns.Add("Downpayment")
                .Columns.Add("AccumulatedPayment")
                .Columns.Add("DateFrom")
                .Columns.Add("DateTo")
            End With
            For Each dr As DataGridViewRow In TransactionSummarySearch.DataGridView1.Rows
                Dim ddate As Date
                ddate = dr.Cells(1).Value
                dt2.Rows.Add(dr.Cells(0).Value, ddate.ToString("yyyy-MM-dd"), dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, _
                             dr.Cells(7).Value, dr.Cells(8).Value & " months", dr.Cells(9).Value, dr.Cells(10).Value, dr.Cells(11).Value, _
                             Date.Parse(TransactionSummarySearch.dateFrom.Value).ToString("yyyy-MM-dd"), Date.Parse(TransactionSummarySearch.dateTo.Value).ToString("yyyy-MM-dd"))
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            If dt.Rows.Count > 0 Then
                MsgBox("Generating Report Preview!")
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New summarytransactionReport
                rptDoc.SetDataSource(dt2)
                ReportViewer.CrystalReportViewer1.ReportSource = rptDoc
                ReportViewer.ShowDialog()
                ReportViewer.Dispose()
            Else
                MsgBox("No results!")
            End If
        End Try
    End Sub
End Module
