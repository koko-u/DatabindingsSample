Public Class MainForm

    Private ReadOnly _model As New Model()
    Private ReadOnly _bindingSource As New BindingSource()


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _bindingSource.DataSource = _model

        NameTextBox.DataBindings.Add(NameOf(TextBox.Text), _bindingSource, NameOf(Model.Name), True, DataSourceUpdateMode.OnPropertyChanged)
        YesNoLabel.DataBindings.Add(NameOf(Label.Text), _bindingSource, NameOf(Model.Flag), True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub ClickButton_Click(sender As Object, e As EventArgs) Handles ClickButton.Click
        MessageBox.Show(_model.Name)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        _model.Name = String.Empty
    End Sub

    Private Sub YesNoLabel_DoubleClick(sender As Object, e As EventArgs) Handles YesNoLabel.DoubleClick
        Dim oppose = Not _model.Flag.Yes
        _model.Flag = New MyFlag() With {.Yes = oppose}
    End Sub
End Class
