﻿Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace ConditionalAppearanceExample.Web
   Partial Public Class ConditionalAppearanceExampleAspNetApplication
       Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
      Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
      Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
      Private module3 As ConditionalAppearanceExample.Module.ConditionalAppearanceExampleModule
      Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
      Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
      Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
      Private conditionalAppearanceExampleWebModule1 As ConditionalAppearanceExample.Module.Web.ConditionalAppearanceExampleWebModule
      Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

      Public Sub New()
         InitializeComponent()
      End Sub

      Private Sub ConditionalAppearanceExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles Me.DatabaseVersionMismatch
         e.Updater.Update()
         e.Handled = True
      End Sub

      Private Sub InitializeComponent()
         Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
         Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
         Me.module3 = New ConditionalAppearanceExample.Module.ConditionalAppearanceExampleModule()
         Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
         Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
         Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
         Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
         Me.conditionalAppearanceExampleWebModule1 = New ConditionalAppearanceExample.Module.Web.ConditionalAppearanceExampleWebModule()
         DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
         ' 
         ' module5
         ' 
         Me.module5.AllowValidationDetailsAccess = True
         ' 
         ' ConditionalAppearanceExampleAspNetApplication
         ' 
         Me.ApplicationName = "ConditionalAppearanceExample"
         Me.Modules.Add(Me.module1)
         Me.Modules.Add(Me.module2)
         Me.Modules.Add(Me.module6)
         Me.Modules.Add(Me.conditionalAppearanceModule1)
         Me.Modules.Add(Me.securityModule1)
         Me.Modules.Add(Me.module3)
         Me.Modules.Add(Me.module5)
         Me.Modules.Add(Me.conditionalAppearanceExampleWebModule1)
         DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

      End Sub
   End Class
End Namespace
