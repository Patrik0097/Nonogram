﻿#pragma checksum "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB0B8A991C08CAD141F1F1D8330520FD81CEEFB2F36C11D840EDC5E9821CDC54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using nonogram;


namespace nonogram.MVVM.View {
    
    
    /// <summary>
    /// ForgotPasswordWindow
    /// </summary>
    public partial class ForgotPasswordWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RequestNewPasswordButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VerificationCodeTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VerificationCodePlaceholder;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VerifyCodeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/nonogram;component/mvvm/view/forgotpasswordwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RequestNewPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
            this.RequestNewPasswordButton.Click += new System.Windows.RoutedEventHandler(this.RequestNewPassword_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.VerificationCodeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.VerificationCodePlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.VerifyCodeButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\MVVM\View\ForgotPasswordWindow.xaml"
            this.VerifyCodeButton.Click += new System.Windows.RoutedEventHandler(this.VerifyCodeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

