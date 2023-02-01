<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRegistrar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtChave = New System.Windows.Forms.TextBox()
        Me.btRegistrar = New System.Windows.Forms.Button()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChave
        '
        Me.txtChave.Location = New System.Drawing.Point(12, 25)
        Me.txtChave.Multiline = True
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Size = New System.Drawing.Size(247, 130)
        Me.txtChave.TabIndex = 0
        '
        'btRegistrar
        '
        Me.btRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrar.Location = New System.Drawing.Point(12, 177)
        Me.btRegistrar.Name = "btRegistrar"
        Me.btRegistrar.Size = New System.Drawing.Size(247, 51)
        Me.btRegistrar.TabIndex = 1
        Me.btRegistrar.Text = "Registrar"
        Me.btRegistrar.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(12, 234)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(247, 51)
        Me.btFechar.TabIndex = 2
        Me.btFechar.Text = "Fechar Sistema"
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'fRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 295)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btRegistrar)
        Me.Controls.Add(Me.txtChave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fRegistrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fRegistrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChave As TextBox
    Friend WithEvents btRegistrar As Button
    Friend WithEvents btFechar As Button
End Class
