Public Class MainController
    'Must inherit from ApplicationContext to take control of application
    Inherits ApplicationContext

    Private m_main As MainForm

    Public Sub New()

        'MyBase.New()
        m_main = New MainForm()
        Me.AttachUIEvents()
        m_main.Show()

    End Sub

    Private Sub AttachUIEvents()

        AddHandler m_main.cmdMessageBox.Click, AddressOf OnMessageBoxClick

    End Sub

    Private Sub OnMessageBoxClick()
        MessageBox.Show("TEST!")
    End Sub

End Class
