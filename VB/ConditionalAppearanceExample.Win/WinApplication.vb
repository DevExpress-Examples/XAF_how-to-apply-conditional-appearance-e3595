﻿Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace ConditionalAppearanceExample.Win
   Partial Public Class ConditionalAppearanceExampleWindowsFormsApplication
       Inherits WinApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
      Public Sub New()
         InitializeComponent()
         DelayedViewItemsInitialization = True
      End Sub

      Private Sub ConditionalAppearanceExampleWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles Me.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
      End Sub
   End Class
End Namespace
