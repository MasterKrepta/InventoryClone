Imports System.Data
Imports MySql.Data.MySqlClient

Public Class InventoryManager

    Public Function ConnectDBase() As List(Of RawMaterial)

        Dim conn As New MySqlConnection("host=127.0.0.1; user=root; password=OKaKaekJpMWbc4Eg; SslMode=none; database=malish_test")
        Dim cmd As MySqlCommand = Nothing
        Dim ret As New List(Of RawMaterial)
        Dim entity As RawMaterial = Nothing

        'cmd = New MySqlCommand("SELECT * FROM inventory")
        cmd = New MySqlCommand("SELECT * FROM inventory")
        cmd.Connection = conn
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Using rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.Default)
            While rdr.Read()
                entity = New RawMaterial()

                entity.PartNumber = rdr("PartNum").ToString()
                entity.PartDescription = rdr("PARTDESC").ToString()
                entity.Quantity = Convert.ToInt32(rdr("QTY"))
                entity.Location = rdr("Location").ToString()
                entity.Price = Convert.ToInt32(rdr("Price"))

                ret.Add(entity)
            End While
        End Using

        Return ret
    End Function

End Class
