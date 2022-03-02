<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DonutBox = New System.Windows.Forms.GroupBox()
        Me.FilledRadioButton = New System.Windows.Forms.RadioButton()
        Me.ChocolateRadioButton = New System.Windows.Forms.RadioButton()
        Me.SugarRadioButton = New System.Windows.Forms.RadioButton()
        Me.GlazedRadioButton = New System.Windows.Forms.RadioButton()
        Me.CoffeeBox = New System.Windows.Forms.GroupBox()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegularRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalDueBox = New System.Windows.Forms.TextBox()
        Me.SaleTaxBox = New System.Windows.Forms.TextBox()
        Me.TextboxSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DonutBox.SuspendLayout()
        Me.CoffeeBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(439, 407)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(90, 47)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(566, 407)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(89, 47)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DonutBox
        '
        Me.DonutBox.Controls.Add(Me.FilledRadioButton)
        Me.DonutBox.Controls.Add(Me.ChocolateRadioButton)
        Me.DonutBox.Controls.Add(Me.SugarRadioButton)
        Me.DonutBox.Controls.Add(Me.GlazedRadioButton)
        Me.DonutBox.Location = New System.Drawing.Point(77, 63)
        Me.DonutBox.Name = "DonutBox"
        Me.DonutBox.Size = New System.Drawing.Size(209, 201)
        Me.DonutBox.TabIndex = 5
        Me.DonutBox.TabStop = False
        Me.DonutBox.Text = "Donuts"
        '
        'FilledRadioButton
        '
        Me.FilledRadioButton.AutoSize = True
        Me.FilledRadioButton.Location = New System.Drawing.Point(7, 141)
        Me.FilledRadioButton.Name = "FilledRadioButton"
        Me.FilledRadioButton.Size = New System.Drawing.Size(91, 19)
        Me.FilledRadioButton.TabIndex = 3
        Me.FilledRadioButton.TabStop = True
        Me.FilledRadioButton.Text = "&Filled ($1.50)"
        Me.FilledRadioButton.UseVisualStyleBackColor = True
        '
        'ChocolateRadioButton
        '
        Me.ChocolateRadioButton.AutoSize = True
        Me.ChocolateRadioButton.Location = New System.Drawing.Point(6, 111)
        Me.ChocolateRadioButton.Name = "ChocolateRadioButton"
        Me.ChocolateRadioButton.Size = New System.Drawing.Size(117, 19)
        Me.ChocolateRadioButton.TabIndex = 2
        Me.ChocolateRadioButton.TabStop = True
        Me.ChocolateRadioButton.Text = "C&hocolate ($1.25)"
        Me.ChocolateRadioButton.UseVisualStyleBackColor = True
        '
        'SugarRadioButton
        '
        Me.SugarRadioButton.AutoSize = True
        Me.SugarRadioButton.Location = New System.Drawing.Point(7, 81)
        Me.SugarRadioButton.Name = "SugarRadioButton"
        Me.SugarRadioButton.Size = New System.Drawing.Size(93, 19)
        Me.SugarRadioButton.TabIndex = 1
        Me.SugarRadioButton.TabStop = True
        Me.SugarRadioButton.Text = "&Sugar ($1.05)"
        Me.SugarRadioButton.UseVisualStyleBackColor = True
        '
        'GlazedRadioButton
        '
        Me.GlazedRadioButton.AutoSize = True
        Me.GlazedRadioButton.Location = New System.Drawing.Point(6, 51)
        Me.GlazedRadioButton.Name = "GlazedRadioButton"
        Me.GlazedRadioButton.Size = New System.Drawing.Size(95, 19)
        Me.GlazedRadioButton.TabIndex = 0
        Me.GlazedRadioButton.TabStop = True
        Me.GlazedRadioButton.Text = "&Glazed($1.05)"
        Me.GlazedRadioButton.UseVisualStyleBackColor = True
        '
        'CoffeeBox
        '
        Me.CoffeeBox.Controls.Add(Me.CappuccinoRadioButton)
        Me.CoffeeBox.Controls.Add(Me.RegularRadioButton)
        Me.CoffeeBox.Controls.Add(Me.NoneRadioButton)
        Me.CoffeeBox.Location = New System.Drawing.Point(439, 63)
        Me.CoffeeBox.Name = "CoffeeBox"
        Me.CoffeeBox.Size = New System.Drawing.Size(216, 200)
        Me.CoffeeBox.TabIndex = 6
        Me.CoffeeBox.TabStop = False
        Me.CoffeeBox.Text = "Coffee"
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(6, 111)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(127, 19)
        Me.CappuccinoRadioButton.TabIndex = 2
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "Ca&ppuccino ($2.75)"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'RegularRadioButton
        '
        Me.RegularRadioButton.AutoSize = True
        Me.RegularRadioButton.Location = New System.Drawing.Point(6, 81)
        Me.RegularRadioButton.Name = "RegularRadioButton"
        Me.RegularRadioButton.Size = New System.Drawing.Size(103, 19)
        Me.RegularRadioButton.TabIndex = 1
        Me.RegularRadioButton.TabStop = True
        Me.RegularRadioButton.Text = "&Regular ($1.50)"
        Me.RegularRadioButton.UseVisualStyleBackColor = True
        '
        'NoneRadioButton
        '
        Me.NoneRadioButton.AutoSize = True
        Me.NoneRadioButton.Location = New System.Drawing.Point(6, 51)
        Me.NoneRadioButton.Name = "NoneRadioButton"
        Me.NoneRadioButton.Size = New System.Drawing.Size(54, 19)
        Me.NoneRadioButton.TabIndex = 0
        Me.NoneRadioButton.TabStop = True
        Me.NoneRadioButton.Text = "&None"
        Me.NoneRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalDueBox)
        Me.GroupBox3.Controls.Add(Me.SaleTaxBox)
        Me.GroupBox3.Controls.Add(Me.TextboxSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(54, 332)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 155)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sale"
        '
        'TotalDueBox
        '
        Me.TotalDueBox.Location = New System.Drawing.Point(115, 108)
        Me.TotalDueBox.Name = "TotalDueBox"
        Me.TotalDueBox.Size = New System.Drawing.Size(100, 23)
        Me.TotalDueBox.TabIndex = 5
        '
        'SaleTaxBox
        '
        Me.SaleTaxBox.Location = New System.Drawing.Point(115, 65)
        Me.SaleTaxBox.Name = "SaleTaxBox"
        Me.SaleTaxBox.Size = New System.Drawing.Size(100, 23)
        Me.SaleTaxBox.TabIndex = 4
        '
        'TextboxSubtotal
        '
        Me.TextboxSubtotal.Location = New System.Drawing.Point(115, 23)
        Me.TextboxSubtotal.Name = "TextboxSubtotal"
        Me.TextboxSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.TextboxSubtotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total due:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sale Tax:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CoffeeBox)
        Me.Controls.Add(Me.DonutBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.DonutBox.ResumeLayout(False)
        Me.DonutBox.PerformLayout()
        Me.CoffeeBox.ResumeLayout(False)
        Me.CoffeeBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DonutBox As GroupBox
    Friend WithEvents FilledRadioButton As RadioButton
    Friend WithEvents ChocolateRadioButton As RadioButton
    Friend WithEvents SugarRadioButton As RadioButton
    Friend WithEvents GlazedRadioButton As RadioButton
    Friend WithEvents CoffeeBox As GroupBox
    Friend WithEvents CappuccinoRadioButton As RadioButton
    Friend WithEvents RegularRadioButton As RadioButton
    Friend WithEvents NoneRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TotalDueBox As TextBox
    Friend WithEvents SaleTaxBox As TextBox
    Friend WithEvents TextboxSubtotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
