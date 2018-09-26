Imports System.Data
Imports MySql.Data.MySqlClient

Class MainWindow
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim im As New InventoryManager


        myComboBox.DataContext = im.ConnectDBase()

        myComboBox.SelectedIndex = 0
    End Sub




End Class
