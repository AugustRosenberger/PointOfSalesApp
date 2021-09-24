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
        Me.components = New System.ComponentModel.Container()
        Me.picbxCompanyImage = New System.Windows.Forms.PictureBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCompanyInfo = New System.Windows.Forms.Label()
        Me.cmbxCPU = New System.Windows.Forms.ComboBox()
        Me.lblCpuStock = New System.Windows.Forms.Label()
        Me.lblMonitorStock = New System.Windows.Forms.Label()
        Me.cmbxMonitor = New System.Windows.Forms.ComboBox()
        Me.lblCpuCost = New System.Windows.Forms.Label()
        Me.lblMonitorCost = New System.Windows.Forms.Label()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.txtMonitor = New System.Windows.Forms.TextBox()
        Me.grpbxAddOn = New System.Windows.Forms.GroupBox()
        Me.chkbxMaintenance = New System.Windows.Forms.CheckBox()
        Me.chkbxWarranty = New System.Windows.Forms.CheckBox()
        Me.grpbxCharges = New System.Windows.Forms.GroupBox()
        Me.lblTaxCharge = New System.Windows.Forms.Label()
        Me.lblTotCosrCharge = New System.Windows.Forms.Label()
        Me.lblSubTotCharge = New System.Windows.Forms.Label()
        Me.lblAddonCharge = New System.Windows.Forms.Label()
        Me.lblMonitorCostCharge = New System.Windows.Forms.Label()
        Me.lblCpuCostCharge = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtMonitorCharge = New System.Windows.Forms.TextBox()
        Me.txtSubTot = New System.Windows.Forms.TextBox()
        Me.txtAddOn = New System.Windows.Forms.TextBox()
        Me.txtCPUCharge = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttCpuInStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCpuCost = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMonitorCost = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMonitorInStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttAddWarent = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMaint = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCalc = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttClear = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttExit = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picbxCompanyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxAddOn.SuspendLayout()
        Me.grpbxCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'picbxCompanyImage
        '
        Me.picbxCompanyImage.Image = Global.AugustRosenberger_project1.My.Resources.Resources.comp_setup
        Me.picbxCompanyImage.Location = New System.Drawing.Point(14, 12)
        Me.picbxCompanyImage.Name = "picbxCompanyImage"
        Me.picbxCompanyImage.Size = New System.Drawing.Size(445, 397)
        Me.picbxCompanyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxCompanyImage.TabIndex = 0
        Me.picbxCompanyImage.TabStop = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(28, 412)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(415, 39)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "August's Computer Shop"
        '
        'lblCompanyInfo
        '
        Me.lblCompanyInfo.AutoSize = True
        Me.lblCompanyInfo.Location = New System.Drawing.Point(70, 458)
        Me.lblCompanyInfo.Name = "lblCompanyInfo"
        Me.lblCompanyInfo.Size = New System.Drawing.Size(315, 96)
        Me.lblCompanyInfo.TabIndex = 2
        Me.lblCompanyInfo.Text = "100 NewYork Ave" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Weehawken, NJ, 07086" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "201-123-4567" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCompanyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxCPU
        '
        Me.cmbxCPU.FormattingEnabled = True
        Me.cmbxCPU.Items.AddRange(New Object() {"GMA4200BST", "TE01-0034", "TE01-0014", "BB985V2"})
        Me.cmbxCPU.Location = New System.Drawing.Point(514, 92)
        Me.cmbxCPU.Name = "cmbxCPU"
        Me.cmbxCPU.Size = New System.Drawing.Size(300, 39)
        Me.cmbxCPU.TabIndex = 3
        Me.cmbxCPU.Tag = ""
        Me.cmbxCPU.Text = "-Select CPU Model-"
        Me.ttCpuInStock.SetToolTip(Me.cmbxCPU, "Select From Available CPU Models")
        '
        'lblCpuStock
        '
        Me.lblCpuStock.AutoSize = True
        Me.lblCpuStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuStock.Location = New System.Drawing.Point(477, 53)
        Me.lblCpuStock.Name = "lblCpuStock"
        Me.lblCpuStock.Size = New System.Drawing.Size(377, 36)
        Me.lblCpuStock.TabIndex = 4
        Me.lblCpuStock.Text = "Available CPU's in Stock:"
        Me.lblCpuStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonitorStock
        '
        Me.lblMonitorStock.AutoSize = True
        Me.lblMonitorStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorStock.Location = New System.Drawing.Point(926, 53)
        Me.lblMonitorStock.Name = "lblMonitorStock"
        Me.lblMonitorStock.Size = New System.Drawing.Size(412, 36)
        Me.lblMonitorStock.TabIndex = 5
        Me.lblMonitorStock.Text = "Available Monitors in Stock:"
        Me.lblMonitorStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxMonitor
        '
        Me.cmbxMonitor.FormattingEnabled = True
        Me.cmbxMonitor.Items.AddRange(New Object() {"ASUS - 24"" LED FHD FreeSync Monitor - Black", "HP - 24f 23.8"" IPS LED FHD FreeSync Monitor - Natural Silver", "Samsung - UR55 Series 28"" IPS 4K UHD Monitor - Dark Gray/Blue", "Dell - 27"" IPS LED FHD FreeSync Monitor - Piano Black"})
        Me.cmbxMonitor.Location = New System.Drawing.Point(960, 92)
        Me.cmbxMonitor.Name = "cmbxMonitor"
        Me.cmbxMonitor.Size = New System.Drawing.Size(330, 39)
        Me.cmbxMonitor.TabIndex = 6
        Me.cmbxMonitor.Tag = ""
        Me.cmbxMonitor.Text = "-Select Monitor Model-"
        Me.ttMonitorInStock.SetToolTip(Me.cmbxMonitor, "Select Monitors In Stock")
        '
        'lblCpuCost
        '
        Me.lblCpuCost.AutoSize = True
        Me.lblCpuCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuCost.Location = New System.Drawing.Point(567, 182)
        Me.lblCpuCost.Name = "lblCpuCost"
        Me.lblCpuCost.Size = New System.Drawing.Size(164, 36)
        Me.lblCpuCost.TabIndex = 7
        Me.lblCpuCost.Text = "CPU Cost:"
        Me.lblCpuCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCpuCost.UseWaitCursor = True
        '
        'lblMonitorCost
        '
        Me.lblMonitorCost.AutoSize = True
        Me.lblMonitorCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorCost.Location = New System.Drawing.Point(1042, 182)
        Me.lblMonitorCost.Name = "lblMonitorCost"
        Me.lblMonitorCost.Size = New System.Drawing.Size(206, 36)
        Me.lblMonitorCost.TabIndex = 8
        Me.lblMonitorCost.Text = "Monitor Cost:"
        Me.lblMonitorCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCPU
        '
        Me.txtCPU.Location = New System.Drawing.Point(514, 235)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(300, 38)
        Me.txtCPU.TabIndex = 9
        Me.ttCpuCost.SetToolTip(Me.txtCPU, "Enter CPU Cost Here")
        '
        'txtMonitor
        '
        Me.txtMonitor.Location = New System.Drawing.Point(990, 235)
        Me.txtMonitor.Name = "txtMonitor"
        Me.txtMonitor.Size = New System.Drawing.Size(300, 38)
        Me.txtMonitor.TabIndex = 10
        Me.ttMonitorCost.SetToolTip(Me.txtMonitor, "Enter Monitor Cost Here")
        '
        'grpbxAddOn
        '
        Me.grpbxAddOn.Controls.Add(Me.chkbxMaintenance)
        Me.grpbxAddOn.Controls.Add(Me.chkbxWarranty)
        Me.grpbxAddOn.Location = New System.Drawing.Point(514, 351)
        Me.grpbxAddOn.Name = "grpbxAddOn"
        Me.grpbxAddOn.Size = New System.Drawing.Size(570, 196)
        Me.grpbxAddOn.TabIndex = 11
        Me.grpbxAddOn.TabStop = False
        Me.grpbxAddOn.Text = "Add Ons:"
        '
        'chkbxMaintenance
        '
        Me.chkbxMaintenance.AutoSize = True
        Me.chkbxMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxMaintenance.Location = New System.Drawing.Point(6, 131)
        Me.chkbxMaintenance.Name = "chkbxMaintenance"
        Me.chkbxMaintenance.Size = New System.Drawing.Size(443, 36)
        Me.chkbxMaintenance.TabIndex = 1
        Me.chkbxMaintenance.Text = "Add Maintenance: + $250.00"
        Me.ttMaint.SetToolTip(Me.chkbxMaintenance, "Add Yearly Maintanince Plan For $250.00")
        Me.chkbxMaintenance.UseVisualStyleBackColor = True
        '
        'chkbxWarranty
        '
        Me.chkbxWarranty.AutoSize = True
        Me.chkbxWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxWarranty.Location = New System.Drawing.Point(6, 64)
        Me.chkbxWarranty.Name = "chkbxWarranty"
        Me.chkbxWarranty.Size = New System.Drawing.Size(390, 36)
        Me.chkbxWarranty.TabIndex = 0
        Me.chkbxWarranty.Text = "Add Warranty: + $125.00"
        Me.ttAddWarent.SetToolTip(Me.chkbxWarranty, "Add Warrenty For an Additional $125.00")
        Me.chkbxWarranty.UseVisualStyleBackColor = True
        '
        'grpbxCharges
        '
        Me.grpbxCharges.Controls.Add(Me.lblTaxCharge)
        Me.grpbxCharges.Controls.Add(Me.lblTotCosrCharge)
        Me.grpbxCharges.Controls.Add(Me.lblSubTotCharge)
        Me.grpbxCharges.Controls.Add(Me.lblAddonCharge)
        Me.grpbxCharges.Controls.Add(Me.lblMonitorCostCharge)
        Me.grpbxCharges.Controls.Add(Me.lblCpuCostCharge)
        Me.grpbxCharges.Controls.Add(Me.txtTotal)
        Me.grpbxCharges.Controls.Add(Me.txtTax)
        Me.grpbxCharges.Controls.Add(Me.txtMonitorCharge)
        Me.grpbxCharges.Controls.Add(Me.txtSubTot)
        Me.grpbxCharges.Controls.Add(Me.txtAddOn)
        Me.grpbxCharges.Controls.Add(Me.txtCPUCharge)
        Me.grpbxCharges.Location = New System.Drawing.Point(76, 592)
        Me.grpbxCharges.Name = "grpbxCharges"
        Me.grpbxCharges.Size = New System.Drawing.Size(1172, 324)
        Me.grpbxCharges.TabIndex = 12
        Me.grpbxCharges.TabStop = False
        Me.grpbxCharges.Text = "Charges:"
        '
        'lblTaxCharge
        '
        Me.lblTaxCharge.AutoSize = True
        Me.lblTaxCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxCharge.Location = New System.Drawing.Point(153, 216)
        Me.lblTaxCharge.Name = "lblTaxCharge"
        Me.lblTaxCharge.Size = New System.Drawing.Size(188, 32)
        Me.lblTaxCharge.TabIndex = 11
        Me.lblTaxCharge.Text = "Tax (6.25%):"
        '
        'lblTotCosrCharge
        '
        Me.lblTotCosrCharge.AutoSize = True
        Me.lblTotCosrCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCosrCharge.Location = New System.Drawing.Point(153, 283)
        Me.lblTotCosrCharge.Name = "lblTotCosrCharge"
        Me.lblTotCosrCharge.Size = New System.Drawing.Size(169, 36)
        Me.lblTotCosrCharge.TabIndex = 10
        Me.lblTotCosrCharge.Text = "Total Cost:"
        '
        'lblSubTotCharge
        '
        Me.lblSubTotCharge.AutoSize = True
        Me.lblSubTotCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotCharge.Location = New System.Drawing.Point(153, 172)
        Me.lblSubTotCharge.Name = "lblSubTotCharge"
        Me.lblSubTotCharge.Size = New System.Drawing.Size(155, 32)
        Me.lblSubTotCharge.TabIndex = 9
        Me.lblSubTotCharge.Text = "Sub Total:"
        '
        'lblAddonCharge
        '
        Me.lblAddonCharge.AutoSize = True
        Me.lblAddonCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddonCharge.Location = New System.Drawing.Point(153, 128)
        Me.lblAddonCharge.Name = "lblAddonCharge"
        Me.lblAddonCharge.Size = New System.Drawing.Size(196, 32)
        Me.lblAddonCharge.TabIndex = 8
        Me.lblAddonCharge.Text = "Add On Cost:"
        '
        'lblMonitorCostCharge
        '
        Me.lblMonitorCostCharge.AutoSize = True
        Me.lblMonitorCostCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorCostCharge.Location = New System.Drawing.Point(153, 84)
        Me.lblMonitorCostCharge.Name = "lblMonitorCostCharge"
        Me.lblMonitorCostCharge.Size = New System.Drawing.Size(196, 32)
        Me.lblMonitorCostCharge.TabIndex = 7
        Me.lblMonitorCostCharge.Text = "Monitor Cost:"
        '
        'lblCpuCostCharge
        '
        Me.lblCpuCostCharge.AutoSize = True
        Me.lblCpuCostCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuCostCharge.Location = New System.Drawing.Point(153, 40)
        Me.lblCpuCostCharge.Name = "lblCpuCostCharge"
        Me.lblCpuCostCharge.Size = New System.Drawing.Size(156, 32)
        Me.lblCpuCostCharge.TabIndex = 6
        Me.lblCpuCostCharge.Text = "CPU Cost:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(438, 280)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(500, 38)
        Me.txtTotal.TabIndex = 5
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(438, 213)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(500, 38)
        Me.txtTax.TabIndex = 4
        '
        'txtMonitorCharge
        '
        Me.txtMonitorCharge.Enabled = False
        Me.txtMonitorCharge.Location = New System.Drawing.Point(438, 81)
        Me.txtMonitorCharge.Name = "txtMonitorCharge"
        Me.txtMonitorCharge.Size = New System.Drawing.Size(500, 38)
        Me.txtMonitorCharge.TabIndex = 3
        '
        'txtSubTot
        '
        Me.txtSubTot.Enabled = False
        Me.txtSubTot.Location = New System.Drawing.Point(438, 169)
        Me.txtSubTot.Name = "txtSubTot"
        Me.txtSubTot.Size = New System.Drawing.Size(500, 38)
        Me.txtSubTot.TabIndex = 2
        '
        'txtAddOn
        '
        Me.txtAddOn.Enabled = False
        Me.txtAddOn.Location = New System.Drawing.Point(438, 125)
        Me.txtAddOn.Name = "txtAddOn"
        Me.txtAddOn.Size = New System.Drawing.Size(500, 38)
        Me.txtAddOn.TabIndex = 1
        '
        'txtCPUCharge
        '
        Me.txtCPUCharge.Enabled = False
        Me.txtCPUCharge.Location = New System.Drawing.Point(438, 37)
        Me.txtCPUCharge.Name = "txtCPUCharge"
        Me.txtCPUCharge.Size = New System.Drawing.Size(500, 38)
        Me.txtCPUCharge.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(1109, 351)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(181, 48)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate"
        Me.ttCalc.SetToolTip(Me.btnCalc, "Calculate Total Cost")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Location = New System.Drawing.Point(1109, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 48)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear "
        Me.ttClear.SetToolTip(Me.btnClear, "Clear All Data")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1109, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(181, 48)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttExit.SetToolTip(Me.btnExit, "Exit Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ttCpuCost
        '
        Me.ttCpuCost.ShowAlways = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 1005)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpbxCharges)
        Me.Controls.Add(Me.grpbxAddOn)
        Me.Controls.Add(Me.txtMonitor)
        Me.Controls.Add(Me.txtCPU)
        Me.Controls.Add(Me.lblMonitorCost)
        Me.Controls.Add(Me.lblCpuCost)
        Me.Controls.Add(Me.cmbxMonitor)
        Me.Controls.Add(Me.lblMonitorStock)
        Me.Controls.Add(Me.lblCpuStock)
        Me.Controls.Add(Me.cmbxCPU)
        Me.Controls.Add(Me.lblCompanyInfo)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.picbxCompanyImage)
        Me.Name = "Form1"
        Me.Text = "August's Computer Shop - Cost Calculator"
        CType(Me.picbxCompanyImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxAddOn.ResumeLayout(False)
        Me.grpbxAddOn.PerformLayout()
        Me.grpbxCharges.ResumeLayout(False)
        Me.grpbxCharges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbxCompanyImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblCompanyInfo As System.Windows.Forms.Label
    Friend WithEvents cmbxCPU As System.Windows.Forms.ComboBox
    Friend WithEvents lblCpuStock As System.Windows.Forms.Label
    Friend WithEvents lblMonitorStock As System.Windows.Forms.Label
    Friend WithEvents cmbxMonitor As System.Windows.Forms.ComboBox
    Friend WithEvents lblCpuCost As System.Windows.Forms.Label
    Friend WithEvents lblMonitorCost As System.Windows.Forms.Label
    Friend WithEvents txtCPU As System.Windows.Forms.TextBox
    Friend WithEvents txtMonitor As System.Windows.Forms.TextBox
    Friend WithEvents grpbxAddOn As System.Windows.Forms.GroupBox
    Friend WithEvents chkbxMaintenance As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxWarranty As System.Windows.Forms.CheckBox
    Friend WithEvents grpbxCharges As System.Windows.Forms.GroupBox
    Friend WithEvents txtCPUCharge As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtMonitorCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTot As System.Windows.Forms.TextBox
    Friend WithEvents txtAddOn As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxCharge As System.Windows.Forms.Label
    Friend WithEvents lblTotCosrCharge As System.Windows.Forms.Label
    Friend WithEvents lblSubTotCharge As System.Windows.Forms.Label
    Friend WithEvents lblAddonCharge As System.Windows.Forms.Label
    Friend WithEvents lblMonitorCostCharge As System.Windows.Forms.Label
    Friend WithEvents lblCpuCostCharge As System.Windows.Forms.Label
    Friend WithEvents ttCpuInStock As System.Windows.Forms.ToolTip
    Friend WithEvents ttCpuCost As System.Windows.Forms.ToolTip
    Friend WithEvents ttMonitorCost As System.Windows.Forms.ToolTip
    Friend WithEvents ttMonitorInStock As System.Windows.Forms.ToolTip
    Friend WithEvents ttAddWarent As System.Windows.Forms.ToolTip
    Friend WithEvents ttMaint As System.Windows.Forms.ToolTip
    Friend WithEvents ttCalc As System.Windows.Forms.ToolTip
    Friend WithEvents ttClear As System.Windows.Forms.ToolTip
    Friend WithEvents ttExit As System.Windows.Forms.ToolTip

End Class
